using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatMovement : MonoBehaviour
{
    public Transform player;
    [SerializeField] public float detectRadius;
    [SerializeField] public float moveSpeed;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        if (distanceToPlayer <= detectRadius)
        {
            //Debug.Log("Player detected by enemy");
            Vector2 catDirection = (player.position - transform.position).normalized;
            rb.velocity = catDirection * moveSpeed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player is ded, must respawn");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
