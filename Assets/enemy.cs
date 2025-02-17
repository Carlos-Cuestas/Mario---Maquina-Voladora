using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] private float velocidad;
    private Rigidbody2D rb2d;
    public int valor = 1;
    public gamemanager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        rb2d.velocity = new Vector2(velocidad * transform.position.x, rb2d.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            gameManager.SumarPuntos(valor);
            Destroy(this.gameObject);
        }
    }
}
