using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockroach : MonoBehaviour
{
    [SerializeField] private float xSpeed;
    [SerializeField] private float ySpeed;
    private Rigidbody2D rb;
    private Vector2 velocity;
    [SerializeField] public int direction; // The direction; 0 is north, 1 is east, 2 is south, 3 is west (the cockroach shall move in a square)
    private float changeInt = 2.0f;
    public float timeSinceChange;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timeSinceChange = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeSinceChange >= changeInt)
        {
            ChangeDirection();
            timeSinceChange = Time.time;
        }
        else
        {
            Debug.Log(direction);
            if (direction == 0)
            {
                rb.velocity = new Vector2(0, ySpeed);
            }
            if (direction == 1)
            {
                rb.velocity = new Vector2(xSpeed, 0);
            }
            if (direction == 2)
            {
                rb.velocity = new Vector2(0, -1.0f * ySpeed);
            }
            if (direction == 3)
            {
                rb.velocity = new Vector2(-1.0f * xSpeed, 0);
            }
            //dist--;
        }
    }

    public void ChangeDirection()
    {
        if (direction == 3)
        {
            direction = 0;
        }
        else
        {
            direction += 1;
        }
    }
}
