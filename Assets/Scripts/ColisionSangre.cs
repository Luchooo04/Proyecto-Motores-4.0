using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionSangre : MonoBehaviour
{

    ParticleSystem Sangre;



    void Start()
    {
        Sangre = GetComponent<ParticleSystem>();
        Sangre.Stop();
    }


    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        Sangre.Stop();
        if (other.tag == "bala")
        {
            Sangre.Play();

        }



    }
}