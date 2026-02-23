using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActDesactObject : MonoBehaviour
{
   //Se definen los parametros implicados (Objeto que va aparecer)   
public GameObject ObjectThatAppear;


       //pedimos que cuando otro collider atraviese el objeto sucedan cosas.
void OnTriggerEnter(Collider other){

    //Ahora hay que asegurarse de que es el jugador el que puede activar esto, y no una silla o una mesa.
if (other.tag == "Player"){
//Que el objeto que estaba inactivo pase a estar activo

ObjectThatAppear.SetActive(true);
}
}
       //pedimos que cuando otro collider salga del collider del objeto sucedan cosas.
void OnTriggerExit(Collider other){
//Ahora hay que asegurarse de que es el jugador el que puede activar esto, y no una silla o una mesa.
if (other.tag == "Player"){

//Que el objeto que estaba inactivo pase a estar inactivo
ObjectThatAppear.SetActive(false);

}
}

}
