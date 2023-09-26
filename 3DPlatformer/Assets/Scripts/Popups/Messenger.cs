using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using EasyUI.Popup;

public class Messenger : MonoBehaviour
{
    public string Text;
    private bool hasEntered = false;
    private UnityAction action;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player") && !hasEntered) {
            hasEntered = true;
            action += enableCursor;
            Popup.Show(Text, action);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    void enableCursor() {
        Debug.Log("Enabled Cursor");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
