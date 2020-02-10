using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalActive : MonoBehaviour
{
    public GameObject player;
    public GameObject panel;

    void OnTriggerEnter()
    {
        if (player.activeSelf is true)
        {
            player.SetActive(false);
        }
        if (panel.activeSelf is false)
        {
            panel.SetActive(true);
        }
    }
}
