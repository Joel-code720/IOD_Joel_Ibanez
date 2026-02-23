using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberObjectsPlayerSurvival : MonoBehaviour
{
    public GameObject TextGameOver;
    public float TimeTillGameClose;
    public Text NumberUI;

    public int NumberObjects = 0;

    void Update()
    {
        NumberUI.text = NumberObjects.ToString();

        // Utiliza == en lugar de === en C#
        if (NumberObjects == 0)
        {
            TextGameOver.SetActive(true);
            Invoke("GameOver", TimeTillGameClose);
        }
    }

    // Esta llave estaba mal ubicada
    public void GameOver()
    {
        // Que el juego termine.
        Application.Quit();
    }
}