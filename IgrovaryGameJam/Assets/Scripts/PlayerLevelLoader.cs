using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelLoader : MonoBehaviour
{
    [SerializeField] private GameObject door;
    [SerializeField] private LevelLoader level;
    [SerializeField] private bool trigger;



    void Update()   {
        if (Input.GetKeyDown(KeyCode.E))    {
            if (door != null && trigger == true)  {
                level.LoadScene();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("BlackDoor"))  {
            trigger = true;
            door = collision.gameObject;
        }
        
        if (collision.CompareTag("WhiteDoor"))  {
            trigger = true;
            door = collision.gameObject;
        }
    }

        private void OnTriggerExit2D(Collider2D collision)  {
        if (collision.CompareTag("BlackDoor"))  {
            if (collision.gameObject == door)   {
                trigger = false;
                door = null;
            }
        }
        
        if (collision.CompareTag("WhiteDoor"))  {
            if (collision.gameObject == door)   {
                trigger = false;
                door = null;
            }
        }
    }
}
