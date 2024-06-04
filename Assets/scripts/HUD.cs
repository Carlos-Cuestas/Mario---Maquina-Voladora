using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    public gamemanager gamemanager;
    public TextMeshProUGUI puntos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text = gamemanager.PuntosTotales.ToString();
      
    }
    
}
