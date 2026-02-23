using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberObjectsPlayer : MonoBehaviour
{

public Text NumberUI;

public int NumberObjects = 0;


void Update()
{
NumberUI.text = ""+ NumberObjects;

}
}
//Este script solo lleva la cuenta de los objetos que recoge el jugador.