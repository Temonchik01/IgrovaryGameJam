using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    [SerializeField] private Transform posA, posB;
    [SerializeField] private int moveSpeed;
    [SerializeField] private Vector2 targetPos;

    void Start() {
        targetPos = posB.position;
    }

    void Update() {
        if(Vector2.Distance(transform.position, posA.position) < .1f) {
            targetPos = posB.position;
        }

        if(Vector2.Distance(transform.position, posB.position) < .1f) {
            targetPos = posA.position;
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed *Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Player")) {
            collision.transform.SetParent(null);
        }
    }

}
