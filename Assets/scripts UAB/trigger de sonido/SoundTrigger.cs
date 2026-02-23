using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundTrigger : MonoBehaviour
{
//Se definen los parametros implicados    
public AudioSource ObjectThatSounds;
public AudioClip Sound;
public float Volume;
//pedimos que cuando otro collider atraviese el objeto sucedan cosas.
private void OnTriggerEnter(Collider other){
//Ahora hay que asegurarse de que es el jugador el que puede activar esto, y no una silla o una mesa.
if (other.tag == "Player"){
//Que el objeto que lleva el script emita un sonido una sola vez y que a la cuenta de 2 segundos el objeto se destruya.
ObjectThatSounds.PlayOneShot(Sound,Volume);
Destroy (this.gameObject, 2.0f);
}
}
}
//Este script reproduce un sonido y luego elimina el objeto. 
//Ejemplo: al atravesar un umbral, se cruza este objeto y se escucha el grito de un monstruo. No volvera a sonar.