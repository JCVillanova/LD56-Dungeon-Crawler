using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator anim;
    public float moveX, lastX = 0, moveY, lastY = -1;
    bool isMoving = false;
    public float playerSpeed = 10.0f;
    int biteCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        anim.SetFloat("moveX", moveX);
        anim.SetFloat("moveY", moveY);
        if(moveX != 0) {
            lastX = moveX;
            isMoving = true;
        }
        if(moveY != 0) {
            lastY = moveY;
            isMoving = true;
        }
        if(moveX == 0 && moveY == 0) {
            isMoving = false;
            anim.SetFloat("lastX", lastX);
            anim.SetFloat("lastY", lastY);
        }
        anim.SetBool("isMoving", isMoving);

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
