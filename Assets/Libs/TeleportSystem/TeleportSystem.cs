using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSystem : MonoBehaviour
{
    public TeleportSystem TeleportTarget;
    public Transform PointTeleport;
    bool teleporting = false;
    public AudioClip OpenSound;
    // public AudioClip CloseSound;
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if(other.GetComponent<InteractionPlayer>() != null){
            InteractionPlayer ip = other.GetComponent<InteractionPlayer>();
            ip.OnActionPress.AddListener(teleport);
            ip.Indicator.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log(other.name);
        if(other.GetComponent<InteractionPlayer>() != null){
            InteractionPlayer ip = other.GetComponent<InteractionPlayer>();
            ip.OnActionPress.RemoveListener(teleport);
            ip.Indicator.SetActive(false);
        }
    }

    public void teleport(){
        if(teleporting) return;
        teleporting = true;
        Transition.instance.OnEventBlackScreen.AddListener(InitTeleport);
        Transition.ActiveTransition();

    }

    public void InitTeleport(){
        Transition.instance.OnEventBlackScreen.RemoveListener(InitTeleport);
        SFXManager.playSound(OpenSound , 1 , 4);
        teleporting = false;
        PlayerWalk.MainPlayer.transform.position = TeleportTarget.PointTeleport.position;
    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(PointTeleport.position, TeleportTarget.PointTeleport.position);
    }
}
