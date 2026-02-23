using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDecrease : MonoBehaviour
{
    public AudioSource ObjectThatSounds;
    public AudioClip Sound;
    public float Volume;

    private bool Damage = false;
    public NumberObjectsPlayerSurvival NumberObjectsPlayerSurvival;
    public float TimeBetweenDecrease = 1f;

    void Start()
    {
        NumberObjectsPlayerSurvival = GameObject.FindGameObjectWithTag("Player").GetComponent<NumberObjectsPlayerSurvival>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Damage = true;
            InvokeRepeating("DecreaseCollectible", 0f, TimeBetweenDecrease);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            CancelInvoke("DecreaseCollectible");
            Damage = false;
        }
    }

    private void DecreaseCollectible()
    {
        if (Damage && NumberObjectsPlayerSurvival.NumberObjects > 0)
        {
            NumberObjectsPlayerSurvival.NumberObjects -= 1;
            ObjectThatSounds.PlayOneShot(Sound, Volume);
        }
    }
}

