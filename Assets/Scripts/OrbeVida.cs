using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbeVida : MonoBehaviour
{
    public GameObject VidaJugador;
    public int Vida;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            VidaJugador.GetComponent<DatosJugador>().vidaPlayer += Vida;
            Destroy(gameObject);
        }
    }
}
