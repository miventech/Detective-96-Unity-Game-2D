using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CurrentRoomUI : MonoBehaviour
{
    public TextMeshProUGUI TextRoom;
    public static CurrentRoomUI instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
}
