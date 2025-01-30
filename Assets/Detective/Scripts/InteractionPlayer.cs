using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionPlayer : MonoBehaviour
{
    public GameObject Indicator;
    public UnityEvent OnActionPress;
    void Start()
    {
        OnActionPress = new UnityEvent();
    }
   
    // Update is called once per frame
    void Update()
    {
        if(ManagerDialog.ShowDialog) return;

        if(Input.GetKeyDown(KeyCode.E)){
            OnActionPress.Invoke();
        }
        // Indicator?.SetActive(true);
    }
}
