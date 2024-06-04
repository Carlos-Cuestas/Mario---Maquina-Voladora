using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COIN : MonoBehaviour
{
    public int valor = 1;
    public gamemanager gameManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gameManager.SumarPuntos(valor);
            Destroy(this.gameObject);
        }
    }
}
