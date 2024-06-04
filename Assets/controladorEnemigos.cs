using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class controladorEnemigos : MonoBehaviour
{
    private float minX, minY, maxX, maxY;
    [SerializeField] private Transform[] puntos;
    [SerializeField] private GameObject[] enemigo;
    [SerializeField] private float tiempoEnemigos;
    private float tiempoSguienteEnemigo;

    void Start()
    {
        maxX = puntos.Max(punto => punto.position.x);
        minX = puntos.Min(punto => punto.position.x);
        maxY = puntos.Max(punto => punto.position.y);
        minY = puntos.Min(punto => punto.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        tiempoSguienteEnemigo += Time.deltaTime;

        if(tiempoSguienteEnemigo >= tiempoEnemigos)
        {
            tiempoSguienteEnemigo = 0;
            CrearEnemigo();
        }
    }

    private void CrearEnemigo()
    {
        int numeroEnemigo= Random.Range(0, enemigo.Length);
        Vector2 posicionAleatoria = new Vector2(Random.Range(minX,maxX), Random.Range(minY, maxY));

        Instantiate(enemigo[numeroEnemigo], posicionAleatoria, Quaternion.identity);
    }
}
