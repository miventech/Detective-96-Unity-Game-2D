using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class EvidenciaObjectTake : MonoBehaviour
{
    public Evidencia evidencia;
    void Start()
    {
        if(GetComponent<BoxCollider2D>() != null){
            GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log(other.name);
        if(other.GetComponent<InteractionPlayer>() != null){
            InteractionPlayer ip = other.GetComponent<InteractionPlayer>();
            ip.OnActionPress.AddListener(takeObject);
            ip.Indicator.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.name);
        if(other.GetComponent<InteractionPlayer>() != null){
            InteractionPlayer ip = other.GetComponent<InteractionPlayer>();
            ip.OnActionPress.RemoveListener(takeObject);
            ip.Indicator.SetActive(false);
        }
    }

    public void  takeObject(){
        EvidenciasUI.addEvidencia(evidencia);
        EvidenciasUI.instance.gameObject.SetActive(true);
        EvidenciasUI.instance.SetEvidencia(evidencia);
        Destroy(this.gameObject);
    }
}
