using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float forceMultiplier = 10f;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private Animator animator;
    public float jumpForce = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        //float moveY = Input.GetAxis("Vertical");
        if (moveX !=0)
        {
            animator.SetBool("IsRun", true);
        } else
        {
            animator.SetBool("IsRun", false);
        }
        // ตรวจสอบการหมุนตามทิศทางที่ตัวละครเคลื่อนที่
        if (moveX > 0 && !facingRight) // ถ้าตัวละครเคลื่อนที่ไปทางขวาแต่หันไปทางซ้าย
        {
            flip();
        }
        else if (moveX < 0 && facingRight) // ถ้าตัวละครเคลื่อนที่ไปทางซ้ายแต่หันไปทางขวา
        {
            flip();
        }

        Vector2 movement = new Vector2(moveX, 0).normalized;
        rb.AddForce(movement * forceMultiplier);
    }

    void flip()
    {
        // หมุนตัวละครโดยการพลิกค่า x ของ scale
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            //animator.SetBool("IsJump",true);
        }
        else
        {
            //animator.SetBool("IsJump",false);
        }
    }
}
