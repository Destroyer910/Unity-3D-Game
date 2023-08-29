using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.Popup;

public class Messenger : MonoBehaviour
{
    public string Text;
    private bool hasEntered = false;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player") && !hasEntered) {
            hasEntered = true;
            Popup.Show(Text);
        }
    }
}
