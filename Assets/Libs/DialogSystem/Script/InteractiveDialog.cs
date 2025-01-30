using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class InteractiveDialog : MonoBehaviour
{
    public Dialog[] Dialogos;
    public bool DestroyBeforeDisplay = true;

    private void Start() {
        if(GetComponent<BoxCollider2D>() != null){
            GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
    void starDialog()
    {
        ManagerDialog.StartDialog(Dialogos);
        if(DestroyBeforeDisplay){
            Destroy(this.gameObject);
        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if(other.GetComponent<InteractionPlayer>() != null){
            InteractionPlayer ip = other.GetComponent<InteractionPlayer>();
            ip.OnActionPress.AddListener(starDialog);
            ip.Indicator.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.name);
        if(other.GetComponent<InteractionPlayer>() != null){
            InteractionPlayer ip = other.GetComponent<InteractionPlayer>();
            ip.OnActionPress.RemoveListener(starDialog);
            ip.Indicator.SetActive(false);
        }
    }
}
