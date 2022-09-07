using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float activeMoveSpeed;
    public float dashSpeed;
    public float dashlenght = 0.3f, dashcooldown = 1f;

    public float dashCounter;
    public float dashcoolCounter;

    Vector2 movement;
    Vector2 mousePos;

    public Rigidbody2D rb;
    public Camera cam;

    void dash ()
    {
        if (Input.GetKeyDown(KeyCode.Space) && dashcoolCounter <= 0 && dashCounter <= 0)
        {
            activeMoveSpeed = dashSpeed;
            dashCounter = dashlenght;
        }
        if (dashCounter > 0)
        {
            dashCounter -= Time.deltaTime;

            if (dashCounter <= 0)
            {
                activeMoveSpeed = moveSpeed;
                dashcoolCounter = dashcooldown;
            }

            if (dashcoolCounter >= 0)
            {
                dashcoolCounter -= Time.deltaTime;
            }
        }

    }
    
    void Start()
    {
        activeMoveSpeed = moveSpeed;
    }
    
    // Update is called once per frame
    void Update()
    {
        // dash();

       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");

       mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
       
    }

    void FixedUpdate()
    {

        rb.MovePosition(rb.position + movement * activeMoveSpeed * Time.fixedDeltaTime);

        Vector2 lookDirection = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }

}
