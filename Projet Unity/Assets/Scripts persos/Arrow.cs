using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int damageAmount = 5;
    
    private void Start()
    {
        Destroy(gameObject, 10);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if(other.tag == "Golem")
        {
            transform.parent = other.transform;
            other.GetComponent<Golem>().TakeDamage(damageAmount);
        }
    }
}
