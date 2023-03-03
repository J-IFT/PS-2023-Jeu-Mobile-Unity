using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementAnimaux : MonoBehaviour {
    
    public float speed = 1;
    void Update()
    {
        // Moves the object forward at two units per second.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}