using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cambiarEscena : MonoBehaviour
{
    //creamos un metodo donde veremos una casilla para colocar el nombre de las escenas
   public void pasarEscena(string nombre)
    {
        //utilizamos scenemanager de unity para hacer un cambio entre escenas
        SceneManager.LoadScene(nombre);
    }
}
