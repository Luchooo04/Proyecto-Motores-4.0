using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Transform ControlDisparo;
    public GameObject Bala;

    public float ForceShot = 1500f;
    public float RateShot = 0.5f;
    public int damage;
    public GameObject zombie;

    private float shotRateTime = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time > shotRateTime)
            {
                GameObject newBala;
                newBala = Instantiate(Bala, ControlDisparo.position, ControlDisparo.rotation);
                newBala.GetComponent<Rigidbody>().AddForce(ControlDisparo.forward * ForceShot);
                shotRateTime = Time.time + RateShot;
                Destroy(newBala, 2);
            }




        }
    }
    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Enemigo") 
        {
            zombie.GetComponent<Enemigo>().vidaEnemigo -= damage;
        }
    }


}
