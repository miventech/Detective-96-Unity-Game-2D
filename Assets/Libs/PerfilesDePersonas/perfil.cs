using UnityEngine;

[CreateAssetMenu(menuName = "Detective 96/Crear Perfil")]
public class perfil : ScriptableObject
{
    public string Nombre;
    public string Apellido;
    public int Edad;
    public string Relacion;
    public string Profesion;
    [TextArea(5 ,50)]
    public string Descripcion;
    [TextArea(5 ,50)]
    public string Anotaciones;
    public Sprite FotoDePerfil;
    public Sprite[] Extras;

}
