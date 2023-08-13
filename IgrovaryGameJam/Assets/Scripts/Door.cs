using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject doorObject;
    [SerializeField] private Vector3 initialDoorPosition;
    [SerializeField] private bool isOpen = false;

    private void Start() {
        initialDoorPosition = doorObject.transform.position;
    }

    public void OpenDoor() {
        if (!isOpen) {
            isOpen = true;
            doorObject.SetActive(false);
        }
    }

    public void CloseDoor() {
        if (isOpen) {
            isOpen = false;
            doorObject.SetActive(true);
        }
    }
}
