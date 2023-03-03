using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Golem : MonoBehaviour
{
    public int HP = 100;
    public Animator animator;
    public Slider healthBar;
    public GameObject Pig;
    public float vitesse = 1f;

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if(HP<=0)
        {
            ScoreScript.scoreValue += 1;
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
        }
        else
        {
            animator.SetTrigger("damage");
        }
    }

    void Update () {
        healthBar.value = HP;
        if (HP > 0) {
            // Déplacer le golem vers la poule
            transform.position = Vector3.MoveTowards(transform.position, Pig.transform.position, vitesse * Time.deltaTime);

            // Si le golem est assez proche de la poule, l'attaquer
            if (Vector3.Distance(transform.position, Pig.transform.position) < 1f) {
                animator.SetTrigger("isAttacking");
                Attaquer();  
            }
        }
    }

    void Attaquer () {
        // Infliger 5 points de dégâts à la poule
        Pig.GetComponent<Poule>().HP -= 10;

        // Si la poule n'a plus de points de vie, la détruire
        if (Pig.GetComponent<Poule>().HP <= 0) {
            Destroy(Pig);
        }
    }
}
