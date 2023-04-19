using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velMovimiento = 5.0f;
    public float velRotacion = 200.0f;
    public float x, y;


    void OnTriggerEnter(Collider col) 
    {
        if (col.CompareTag("Puño")) 
        {
            print("Daño");
        }
    }

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velMovimiento);



        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}