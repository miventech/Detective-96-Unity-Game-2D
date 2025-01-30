using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRoom : MonoBehaviour
{
    public string RoomName;
    void OnTriggerEnter2D(Collider2D other)
    {
        CurrentRoomUI.instance.TextRoom.text = RoomName;
        CurrentRoomUI.instance.gameObject.SetActive(false);
        CurrentRoomUI.instance.gameObject.SetActive(true);
    }
}
