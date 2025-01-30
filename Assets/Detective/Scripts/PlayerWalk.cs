using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public static PlayerWalk MainPlayer;
    public float velMov = 3;
    float ScaleBase = 0;
    public bool Right = true;
    public Animator AnimPlayer;
    // Start is called before the first frame update
    void Start()
    {
        MainPlayer = this;
        ScaleBase = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(ManagerDialog.ShowDialog){
            AnimPlayer.SetBool("Walk", false);
            return;
        }
        float Mov = Input.GetAxis("Horizontal")  * Time.deltaTime * velMov;
        if (Mov != 0)
        {
            AnimPlayer.SetBool("Walk", true);
            if (Mov > 0)
            {
                Right = true;
            }
            else if (Mov < 0)
            {
                Right = false;
            }
        }else{
            AnimPlayer.SetBool("Walk", false);
        }


        if(Right){
            transform.localScale = ScaleBase * Vector3.one;
        }else{
            transform.localScale = new Vector3(-ScaleBase, ScaleBase, ScaleBase);
        }
        transform.position += transform.right * Mov;
    }

    
}
