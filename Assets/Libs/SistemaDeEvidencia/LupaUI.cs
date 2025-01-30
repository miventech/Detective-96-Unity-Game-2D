using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class LupaUI : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{

    public TextMeshProUGUI UsosLupa;
    void Start()
    {
        BuscadorEvidencia.SetStateLight(false);
        BuscadorEvidencia.instance.OnChangeUsos.AddListener(() =>
        {
            UsosLupa.text = BuscadorEvidencia.instance.Usos.ToString();
        });
        UsosLupa.text = BuscadorEvidencia.instance.Usos.ToString();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        BuscadorEvidencia.instance.InitBusqueda();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        BuscadorEvidencia.SetStateLight(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        BuscadorEvidencia.SetStateLight(false);

    }

}
