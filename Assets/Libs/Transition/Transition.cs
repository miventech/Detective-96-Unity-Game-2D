using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Transition : MonoBehaviour
{
    public static Transition instance;
    public UnityEvent OnEventBlackScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        OnEventBlackScreen = new UnityEvent();
        instance = this;
        instance.gameObject.SetActive(false);
    }
    public static void ActiveTransition(){
        instance.gameObject.SetActive(false);
        instance.gameObject.SetActive(true);
    }
    public void callEventBlackScreen(){
        OnEventBlackScreen.Invoke();
    }
}
