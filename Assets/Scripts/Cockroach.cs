using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cockroach : MonoBehaviour
{
    [SerializeField] private float xSpeed;
    [SerializeField] private float ySpeed;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Vector2 velocity;
    [SerializeField] public int direction; // The direction; 0 is north, 1 is east, 2 is south, 3 is west (the cockroach shall move in a square)
    [SerializeField] private float intervalBeforeDirectionChange;
    public float timeSinceChange;

    [SerializeField] private Sprite north;
    [SerializeField] private Sprite east;
    [SerializeField] private Sprite south;
    [SerializeField] private Sprite west;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timeSinceChange = Time.time;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - timeSinceChange >= intervalBeforeDirectionChange)
        {
            ChangeDirection();
            timeSinceChange = Time.time;
        }
        else
        {
            //Debug.Log(direction);
            if (direction == 0)
            {
                rb.velocity = new Vector2(0, ySpeed);
                spriteRenderer.sprite = north;
            }
            if (direction == 1)
            {
                rb.velocity = new Vector2(xSpeed, 0);
                spriteRenderer.sprite = east;
            }
            if (direction == 2)
            {
                rb.velocity = new Vector2(0, -1.0f * ySpeed);
                spriteRenderer.sprite = south;
            }
            if (direction == 3)
            {
                rb.velocity = new Vector2(-1.0f * xSpeed, 0);
                spriteRenderer.sprite = west;
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

    public void reverse()
    {
        if (direction == 0)
        {
            Debug.Log("reversing");
            direction = 2;
        }
        else if (direction == 1)
        {
            direction = 3;
        }
        else if (direction == 2)
        {
            direction = 0;
        }
        else if (direction == 3)
        {
            direction = 1;
        }
        Debug.Log("Direction is: ");
        Debug.Log(direction);
    }
}
