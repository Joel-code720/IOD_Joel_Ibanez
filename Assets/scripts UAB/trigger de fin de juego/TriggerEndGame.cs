using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class TriggerEndGame : MonoBehaviour
{
    public GameObject TextGameOver;
    public float TimeTillGameClose;
    //pedimos que cuando otro collider atraviese el objeto sucedan cosas.
void OnTriggerEnter(Collider other){
    //Ahora hay que asegurarse de que es el jugador el que puede activar esto, y no una silla o una mesa.
if (other.tag == "Player"){
//Muestra el texto de Fin del Juego
TextGameOver.SetActive (true);
Invoke ("GameOver", TimeTillGameClose);

}
}
public void GameOver () 
{
    //Que el juego termine.
Application.Quit();
}

}
