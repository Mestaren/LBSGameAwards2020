using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100; // hälsa av fiender
    int currentHealth; 
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void takeDamage(int Damage)
    {
        currentHealth -= Damage; // hur mycket skada som fienden ska ta

        animator.SetTrigger("hurt");

        if(currentHealth <= 0)
        {
            Die(); //die
        }

        void Die()
        {
            Debug.Log("you killed him");
            animator.SetBool("isDead", true);

            GetComponent<Collider2D>().enabled = false; // stänger av collider så jag inte kan interacta med den
            this.enabled = false; // disable enemy script
        }
    }
}
