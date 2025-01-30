using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class EvidenciasUI : MonoBehaviour
{
    public static EvidenciasUI instance;
    public TextMeshProUGUI NumeroDeEvidenciasText;
    public  List<Evidencia> Evidencias;
    public int CurrentPosition;
    public Sprite DefaultPrueba;
    public Image ImagenPrueba;
    public int MaxEvidencias = 5;
    public TextMeshProUGUI Title;
    public TextMeshProUGUI Detalles;

    public UnityEvent AllEvidencesTake;
    // Start is called before the first frame update
    void Start()
    {
        Evidencias = new List<Evidencia>();
        instance = this;
        gameObject.SetActive(false);
        NumeroDeEvidenciasText.text = "Evidencias: 0";
        Next();
        // AllEvidencesTake.Invoke();
    }

    public void Next(){
        CurrentPosition++;
        checkEvidencia();
    }

    public void Previous(){
        CurrentPosition--;
        checkEvidencia();
    }

    public static void addEvidencia(Evidencia evi){
        instance.Evidencias.Add(evi);
        instance.NumeroDeEvidenciasText.text = $"Evidencias: {instance.Evidencias.Count}";
        if(instance.Evidencias.Count >= instance.MaxEvidencias){
            instance.AllEvidencesTake?.Invoke();
        }
    }


    void checkEvidencia(){
        if (Evidencias.Count != 0)
        {
            if (CurrentPosition >= Evidencias.Count)
            {
                CurrentPosition = 0;
            }
            else if (CurrentPosition < 0)
            {
                CurrentPosition = (Evidencias.Count - 1);
            }
            SetEvidencia(Evidencias[CurrentPosition]);

        }else{
            CurrentPosition = 0;
            Evidencia evi = new Evidencia();
            evi.Descripcion = "No Posee ninguna prueba";
            evi.Nombre = "No Posee ninguna prueba";
            evi.ImagePrueba = DefaultPrueba;
            SetEvidencia(evi);
        }
    }
    public void SetEvidencia(Evidencia evidencia){
        ImagenPrueba.sprite = evidencia.ImagePrueba;
        Title.text = evidencia.Nombre;
        Detalles.text = evidencia.Descripcion;
    }
}
