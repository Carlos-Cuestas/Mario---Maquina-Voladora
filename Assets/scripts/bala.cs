using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    
    void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
    }

   
}
