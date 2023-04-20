using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoEnemigo1 : MonoBehaviour
{
    public int damage;
    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.GetComponent<DatosJugador>().vidaPlayer -= damage;
        }

        if (other.CompareTag ("Puño"))
        {
            Debug.Log("Esto es una enemigo");
        }

    }
}

