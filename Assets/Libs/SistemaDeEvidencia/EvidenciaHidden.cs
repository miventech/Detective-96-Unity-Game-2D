using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class EvidenciaHidden : MonoBehaviour
{
    public GameObject ObjectADescubrir;
     private void Start() {
        if(GetComponent<BoxCollider2D>() != null){
            GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
    public void encontrada()
    {
        ObjectADescubrir.gameObject.SetActive(true);
        Destroy(this);
    }
}
