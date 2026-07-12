using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    
    public Rigidbody2D rigidbody;
    public GameObject camera;
    public int moveSpeed = 5;
    public int jumpPower = 6;
    public bool isGrounded = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
        posupdate();
    }

    void posupdate()
    {
        camera.transform.position =
            new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.velocity = Vector2.right * moveSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.velocity = Vector2.left * moveSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.velocity = Vector2.left * moveSpeed;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded)
            {
                isGrounded = false;
                rigidbody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
                camera.GetComponent<AudioSource>().Play();
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                isGrounded = false;
                rigidbody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
                camera.GetComponent<AudioSource>().Play();
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.velocity = Vector2.right * moveSpeed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.velocity = Vector2.left * moveSpeed;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isGrounded)
            {
                isGrounded = false;
                rigidbody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
                camera.GetComponent<AudioSource>().Play();
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.velocity = Vector2.left * moveSpeed;
        }
    }
}
