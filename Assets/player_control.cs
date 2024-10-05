using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    Rigidbody2D rb2d;
    float moveX;
    float moveY;
    public float playerSpeed = 10.0f;
    int biteCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        if(Input.GetButtonDown("Bite")) {
            Debug.Log("Bite called (" + biteCount + ")");
            biteCount++;
        }
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(moveX, moveY).normalized * playerSpeed;
    }
}
