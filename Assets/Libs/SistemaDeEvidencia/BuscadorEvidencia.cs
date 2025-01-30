using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuscadorEvidencia : MonoBehaviour
{
    public static BuscadorEvidencia instance;
    public GameObject LightRadius;
    public float radiusBusqueda = 0.3f;
    public LayerMask mask;
    public int Usos = 5;
    public UnityEvent OnChangeUsos;
    public AudioClip SoundSucces;
    public AudioClip SoundError;
    public AudioClip ZoomSFX;

    private void Awake() {
        instance = this;
        OnChangeUsos = new UnityEvent();
    }
    
    public static void SetStateLight(bool state){
        instance.LightRadius.SetActive(state);
        if(state)SFXManager.playSound(instance.ZoomSFX);
    }

    public void InitBusqueda(){
        if(Usos <= 0) return;
        bool successFind = false;
        Collider2D[] Cols = Physics2D.OverlapCircleAll(transform.position, radiusBusqueda);
        LightRadius.SetActive(false);
        LightRadius.SetActive(true);

        foreach (Collider2D col in Cols)
        {
            if(col.GetComponent<EvidenciaHidden>() != null){
                col.GetComponent<EvidenciaHidden>().encontrada();
                successFind = true;
            }
        }
        AudioClip clip = successFind ? SoundSucces : SoundError;
        SFXManager.playSound(clip);
        Usos--;
        OnChangeUsos.Invoke();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radiusBusqueda);
    }
}
