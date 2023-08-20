using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    [SerializeField] private Transform posA, posB;
    [SerializeField] private int moveSpeed;
    [SerializeField] private Vector2 targetPos;

    [SerializeField] List<Transform> passengers = new List<Transform>();

    void Start()
    {
        targetPos = posB.position;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, posA.position) < 0.1f)
        {
            targetPos = posB.position;
        }

        if (Vector2.Distance(transform.position, posB.position) < 0.1f)
        {
            targetPos = posA.position;
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

        foreach (Transform passenger in passengers)
        {
            passenger.Translate(targetPos - (Vector2)transform.position);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            passengers.Add(collision.transform);
            collision.transform.SetParent(transform);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            passengers.Remove(collision.transform);
            collision.transform.SetParent(null);
        }
    }

}
