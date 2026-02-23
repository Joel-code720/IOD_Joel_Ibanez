using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivationObject : MonoBehaviour
{
    //Se definen los parametros implicados (Objeto que va a aparecer)   
public GameObject ObjectThatAppear;

       //pedimos que cuando otro collider (jugador) atraviese el objeto sucedan cosas.
void OnTriggerEnter(Collider other){
    //Ahora hay que asegurarse de que es el jugador el que puede activar esto, y no una silla o una mesa.
if (other.tag == "Player"){
//Que el objeto que estaba inactivo pase a estar activo
ObjectThatAppear.SetActive(true);
}
}
}

