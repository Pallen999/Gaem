using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    //public Animator animator;

    public Transform attack_point;
    public float attackRange = 0.5f;
    public LayerMask enemyleyers;
    public int attackdmg = 30;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
            
        }   
    }

    //vadsom händer när "attack" sker
    void Attack()
    {
        //animation
        //animator.SetTrigger("Attack");

        // kod för att "märka" vilka enemy som är in range och kan bli träffade
        Collider[] hitenemys = Physics.OverlapSphere(attack_point.position, attackRange, enemyleyers);  

        //skada

        foreach(Collider enemy in hitenemys)
        {
            enemy.GetComponent<enemy>().takedmg(10);
                
               
           
        }


    }

    void OnDrawGizmosSelected()
    {

        if (attack_point == null)
            return;
        Gizmos.DrawWireSphere(attack_point.position, attackRange);
        
    }
    















}




