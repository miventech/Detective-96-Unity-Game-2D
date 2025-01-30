using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PerfilUI : MonoBehaviour
{
    public perfil[] Perfiles;
    public int CurrentPerfil = 0;
    public TextMeshProUGUI Nombre;
    public TextMeshProUGUI Apellido;
    public TextMeshProUGUI Edad;
    public TextMeshProUGUI Relacion;
    public TextMeshProUGUI Profesion;
    public TextMeshProUGUI Descripcion;
    public TextMeshProUGUI Anotaciones;
    public Image FotoPerfil;

    public AudioClip ClipSfx;
    void Start()
    {
        checkPerfil();
    }
    void OnEnable()
    {
        SFXManager.playSound(ClipSfx, Random.Range(0.5f, 1));
    }
    public void Next(){
        CurrentPerfil++;
        checkPerfil();
    }

    public void Prev(){
        CurrentPerfil--;
        checkPerfil();
    }

    public void checkPerfil(){
        if(CurrentPerfil >= Perfiles.Length) CurrentPerfil = 0;
        if(CurrentPerfil < 0) CurrentPerfil = Perfiles.Length-1;
        UpdatePerfil(Perfiles[CurrentPerfil]);
    }

    public void UpdatePerfil(perfil perfilUpdate)
    {
        SFXManager.playSound(ClipSfx, Random.Range(0.5f, 1));

        Nombre.text = $"Nombres: {perfilUpdate.Nombre}";
        Apellido.text = $"Apellidos: {perfilUpdate.Apellido}";
        Edad.text = $"Edad: {perfilUpdate.Edad}";
        Relacion.text = $"{perfilUpdate.Relacion}";
        Profesion.text = $"Profesion: {perfilUpdate.Profesion}";
        Descripcion.text = $"Descripcion: {perfilUpdate.Descripcion}";
        Anotaciones.text = $"Observacion : {perfilUpdate.Anotaciones}";
        FotoPerfil.sprite = perfilUpdate.FotoDePerfil;
    }
}
