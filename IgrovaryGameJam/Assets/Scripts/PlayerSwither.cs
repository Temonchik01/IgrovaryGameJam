using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwither : MonoBehaviour
{
    public GameObject character1;
    public GameObject character2;

    public GameObject transperancy1;
    public GameObject transperancy2;

    private Movement movement1;
    private Movement movement2;

    private GameObject activeCharacter;

    private GameObject transperancy;



    private void Start()
    {
        movement1 = character1.GetComponent<Movement>();
        movement2 = character2.GetComponent<Movement>();

        transperancy = transperancy2;
        activeCharacter = character1;

        character1.SetActive(true);
        transperancy1.SetActive(false);

        character2.SetActive(false);
        transperancy2.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SwitchCharacter();
        }
    }

    private void SwitchCharacter()
    {
        movement1.canDash = true;
        movement2.canDash = true;
        transperancy.SetActive(false);
        activeCharacter.SetActive(false);

        if (activeCharacter == character1)
        {
            activeCharacter = character2;
            transperancy = transperancy1;
        }
        else
        {
            activeCharacter = character1;
            transperancy = transperancy2;
        }

        activeCharacter.SetActive(true);
        transperancy.SetActive(true);
    }
}
