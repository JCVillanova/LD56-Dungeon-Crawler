using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator anim;
    public float moveX, lastX, moveY, lastY, lastDir = 4;
    bool isMoving = false;
    public float playerSpeed = 10.0f;
    int biteCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetFloat("lastDir", lastDir);
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        if(moveX != 0) lastX = moveX;
        moveY = Input.GetAxisRaw("Vertical");
        if(moveY != 0) lastY = moveY;
        anim.SetFloat("moveX", moveX);
        anim.SetFloat("moveY", moveY);
        if(moveX != 0 || moveY != 0) {
            isMoving = true;
            if(moveX == 0) {
                if(lastY == 1) {
                    lastDir = 3;
                } else lastDir = 4;
            } else if (moveY == 0) {
                if(lastX == 1) {
                    lastDir = 2;
                } else lastDir = 1;
            }
        } else {
            isMoving = false;
            anim.SetFloat("lastDir", lastDir);
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
