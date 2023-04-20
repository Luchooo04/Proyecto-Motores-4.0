using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DatosJugador : MonoBehaviour
{
    public int vidaPlayer;
    public Slider vidaVisual;
    
    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;
        
        
        if (vidaPlayer <= 0) 
        {
            SceneManager.LoadScene(0);
            Debug.Log("GAME OVER");
        
        } 
       
    }
}
