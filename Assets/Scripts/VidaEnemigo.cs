using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{


    public int balas_disparadas;  //Balas disparadas y que le han dado al enemigo.
    public int balas_necesarias; //Las balas que se necesitan para matar al enemigo.


    void OnTriggerEnter(Collider other )
    {
        if (other.tag == "bala")//Si toca el tag "bala". 
        {
            balas_disparadas += 1; //Suma 1 a las balas disparadas.
            Destroy(other.gameObject);//Destruye la bala.
            if (balas_necesarias == balas_disparadas)//Si han tocado al jugador el número de balas necesarias.
            {

                GameManager.instance.AddEnemyKill();
                Destroy(this.gameObject);//Destruye este objeto.

            }
        }
    }
}
