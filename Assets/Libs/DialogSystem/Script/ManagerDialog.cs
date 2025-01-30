using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManagerDialog : MonoBehaviour
{
    public Dialog[] ListDialog;
    public int CurrentDialog = 0;
    [Range(0.001f, 0.5f)]
    public float VelChar = 0.01f;
    public bool Writing = true;
    public TextMeshProUGUI Nombre;
    public TextMeshProUGUI Texto;
    public Image ImgPersona;
    public static ManagerDialog instance;
    public AudioClip openDialog;
    public AudioClip CharSound;

    public static bool ShowDialog = false;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        gameObject.SetActive(false);
    }

    void OnEnable()
    {
        ShowDialog = true;
        SFXManager.playSound(openDialog, Random.Range(0.5f, 1), 2);
    }
    void OnDisable()
    {
        ShowDialog = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(Writing){
            if (skip())
            {
                Writing = false;
                StopAllCoroutines();
                Texto.text = ListDialog[CurrentDialog].Texto;
            }
        }else{
            if (skip())
            {
                nextDialog();
            }
        }
    }

    public void nextDialog(){
        CurrentDialog++;
        if(CurrentDialog >= ListDialog.Length){
            close();
        }else
        {
            setDialog(ListDialog[CurrentDialog]);
        }
    }

    public void setDialog(Dialog dialog){
        Texto.text = "";
        SFXManager.playSound(openDialog, Random.Range(0.5f, 1), 2);
        StartCoroutine(WritingText(dialog.Texto));
        Nombre.text = dialog.Nombre;
        ImgPersona.sprite = dialog.Foto;
        ListDialog[CurrentDialog].onThisDialog?.Invoke();

    }
    private void close()
    {
        ListDialog = new Dialog[0];
        gameObject.SetActive(false);
    }

    bool skip(){
        if(Input.GetKeyDown(KeyCode.E)){
            return true;
        }
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            return true;
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            return true;
        }
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            return true;
        }
        return false;

    }
    IEnumerator WritingText(string textW){
        Writing = true;
        Texto.text = "";
        
        yield return new WaitForSeconds(0);
        foreach (char c in textW)
        {
            Texto.text += c;
            yield return new WaitForSeconds(VelChar);
            if (CharSound != null)
            {
                SFXManager.playSound(CharSound, Random.Range(0.5f, 1), 4);
            }
        }
        Writing = false;
    }

    public static void StartDialog(Dialog[] Dialogs){
        instance.ListDialog = Dialogs;
        instance.CurrentDialog = 0;
        instance.gameObject.SetActive(true);
        instance.setDialog(Dialogs[0]);
    }
}
