using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Detective 96/Crear Evidencia")]
public class Evidencia : ScriptableObject
{
    public string Nombre = "";
    [TextArea(10 , 40)]
    public string Descripcion = "";
    public Sprite ImagePrueba;
}
