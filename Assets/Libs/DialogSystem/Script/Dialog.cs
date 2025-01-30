using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Dialog
{
    public string Nombre;
    [TextArea(10, 30)]
    public string Texto;
    public Sprite Foto;
    public UnityEvent onThisDialog;
}
