using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
//Se definen los parametros implicados    
public AudioSource ObjectThatSounds;
public AudioClip Sound;
public float Volume;
public GameObject ObjectCollectible;

 //llamamos al script que cuenta el total de objetos
public NumberObjectsPlayer NumberObjectsPlayer;
void Start()
{
  NumberObjectsPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<NumberObjectsPlayer>();  
}


//pedimos que cuando otro collider atraviese el objeto sucedan cosas.
private void OnTriggerEnter(Collider other){
//Ahora hay que asegurarse de que es el jugador el que puede activar esto, y no una silla o una mesa.
if (other.tag == "Player"){
//Que el objeto que lleva el script emita un sonido una sola vez y que a la cuenta de un segundo el objeto se destruya.
ObjectThatSounds.PlayOneShot(Sound,Volume);
//Al atravesar el collider se suma + 1 coleccionable 
NumberObjectsPlayer.NumberObjects = NumberObjectsPlayer.NumberObjects + 1;
//Le pediremos al script que nada mas atrevesar el objeto nos lo esconda para que de tiempo a reproducir el sonido
ObjectCollectible.GetComponent<MeshRenderer>().enabled = false;
//El objeto se destruira tras un segundo.
Destroy (this.gameObject, 1.0f);
}
}
} 
//Este script  nos suma un objeto de inventario, reproduce un sonido, 
//esconde la geometria el tiempo justo para que suene el audio y luego elimina el objeto. 

