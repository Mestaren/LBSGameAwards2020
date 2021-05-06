using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //if statement som registrerar om jag trycker ner space knappen
        {
            Attack(); //kallar på funktionen attack varje gång jag trycker space 
        }
    }


    void Attack()
    {
        //spela en attack animation
        animator.SetTrigger("Attack down");



    }
}
