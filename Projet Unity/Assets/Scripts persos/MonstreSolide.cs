using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonstreSolide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerArmature"))
        {
            // Empêcher le joueur de traverser le monstre en activant la collision
            GetComponent<Collider>().isTrigger = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerArmature"))
        {
            // Autoriser à nouveau le joueur à traverser le monstre en désactivant la collision
            GetComponent<Collider>().isTrigger = true;
        }
    }
}

