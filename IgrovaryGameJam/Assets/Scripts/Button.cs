using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private Door doorController;
    [SerializeField] private bool isActivated = false;
    [SerializeField] private AudioManager audioManager;

    void Awake() {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            audioManager.PlaySFX(audioManager.ButtonOn);
            doorController.OpenDoor();
            isActivated = true;
        }
        if(other.CompareTag("Crate")) {
            audioManager.PlaySFX(audioManager.ButtonOn);
            doorController.OpenDoor();
            isActivated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            audioManager.PlaySFX(audioManager.ButtonOff);
            doorController.CloseDoor();
            isActivated = false;
        }
        if(other.CompareTag("Crate")) {
            audioManager.PlaySFX(audioManager.ButtonOff);
            doorController.CloseDoor();
            isActivated = false;
        }
    }
}
