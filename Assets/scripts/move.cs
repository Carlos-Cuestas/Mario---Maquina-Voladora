using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    public float moveSpeed;    
    public Rigidbody2D rb;
    private Vector2 moveDiretion;


   

    private void Update()
    {
        ProcessInput();
        //procesa los inputs
    }

    private void FixedUpdate()
    {
        Move();
        //calcula las fisicas
        rb.position = new Vector2(Mathf.Clamp(rb.position.x, -7.5f, 7.5f), Mathf.Clamp(rb.position.y, -4f, 3.33f));
    }

     void ProcessInput()
    {
        float movex = Input.GetAxisRaw("Horizontal");
        float movey = Input.GetAxisRaw("Vertical");

        moveDiretion = new Vector2( movex, movey ); //TODO RETORNA ACA
    }

     void Move()
    {
        rb.velocity = new Vector2(moveDiretion.x * moveSpeed, moveDiretion.y * moveSpeed); //calcula la velocidad y direccion
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            
            
                //utilizamos scenemanager de unity para hacer un cambio entre escenas
                SceneManager.LoadScene(0);
            
        }
    }

}
