using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

    public Transform AttackPoint; //detta ska då referera till Attackpoint objectet som är attachat med the hero
    public float attackRange = 0.5f; //attack ragen för själva attacken
    public LayerMask enemyLayers; // detta är till för att man bara ska kunna slå fiender så man assignar dem layers
    public int AttackDamage = 20; //attack skada

    public float attackRate = 2f;
    float nextAttackTime = 0f;

   
    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space)) //if statement som registrerar om jag trycker ner space knappen
            {
                Attack(); //kallar på funktionen attack varje gång jag trycker space 
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
        
    }



    void Attack()
    {
        //spela en attack animation
        animator.SetTrigger("Attack down");
        // kunna se vilka fiender som jag träffar
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, attackRange, enemyLayers); // detta kommer då skapa en circel som man kan se i unity scene tool för att ta in information som finns inom circklen
        //själva attacken
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().takeDamage(AttackDamage); //visar hur mycket skada fiender ska ta
        }
    }

    private void OnDrawGizmosSelected()
    {
        if(AttackPoint == null)
            return;
        

        Gizmos.DrawWireSphere(AttackPoint.position, attackRange);//ritar yupp en circkel så man kan se var attack rangen är
    }
}
