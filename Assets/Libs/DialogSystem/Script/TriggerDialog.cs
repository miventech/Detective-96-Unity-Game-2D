using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class TriggerDialog : MonoBehaviour
{
    public Dialog[] Dialogos;
    public bool DestroyBeforeDisplay = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        startDialogo();
        Destroy(this);
    }

    public void startDialogo(){
        ManagerDialog.StartDialog(Dialogos);
    }

}
