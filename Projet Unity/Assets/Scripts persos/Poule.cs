using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poule : MonoBehaviour
{
    public int HP = 50;

    void Update () 
    {
        // Si la poule n'a plus de points de vie, la détruire
        if (HP <= 0) {
            Destroy(gameObject);
        }
    }
}
