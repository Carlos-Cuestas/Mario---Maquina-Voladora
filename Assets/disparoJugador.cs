using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoJugador : MonoBehaviour
{
    [SerializeField] private Transform shootControler;
    [SerializeField] private GameObject bullet;
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
         
    }

    private void Disparar()
    {
        Instantiate(bullet, shootControler.position, shootControler.rotation);
    }
}
