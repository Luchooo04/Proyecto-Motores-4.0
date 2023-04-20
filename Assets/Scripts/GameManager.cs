using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text EnemigosMuertos;
    public int TotalMuertes;
    public GameObject enemyContainer;
    void Start()
    {
        instance = this;
        TotalMuertes = enemyContainer.GetComponentsInChildren<Enemigo>().Length;
        EnemigosMuertos.text="Enemigos Totales:" + TotalMuertes.ToString();
    }
    public void AddEnemyKill() 
    {
        TotalMuertes--;
        EnemigosMuertos.text = "Enemigos Totales:" + TotalMuertes.ToString();
    }

    
}