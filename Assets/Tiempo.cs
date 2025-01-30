using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Tiempo : MonoBehaviour
{
    public int Hora = 9;
    public int Minutos = 0;
    public int IncrementForMin = 10;
    public int LimitHour = 20;
    public TextMeshProUGUI TextTime;
    public UnityEvent OnLimitHours;
    void Start()
    {
        OnLimitHours = new UnityEvent();
        StartCoroutine(TimeLoop());
    }

    IEnumerator TimeLoop(){
        UpdateText();
        while (true)
        {
            yield return new WaitForSeconds(15f);
            Minutos += IncrementForMin;
            if(Minutos >= 60){
                Minutos = 0;
                BuscadorEvidencia.instance.Usos++;
                BuscadorEvidencia.instance.OnChangeUsos.Invoke();
                Hora++;
            }
            UpdateText();
            if(Hora >= LimitHour){
                OnLimitHours.Invoke();
            }
        }
    }

    public void UpdateText(){
        if(TextTime != null){
            TextTime.text = $"{Hora.ToString("00")}:{Minutos.ToString("00")}";
        }
    }
}
