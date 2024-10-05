using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private Cockroach entity;
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag("Cockroach"))
        {
            Debug.Log("a collision happened");
            entity = c.gameObject.GetComponent<Cockroach>();
            if (entity != null)
            {
                entity.ChangeDirection();
                entity.timeSinceChange = Time.time;
            }
        }
    }
}
