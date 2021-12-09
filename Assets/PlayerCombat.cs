using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Attack();
        }
    }

    void Attack()
    {
        //play atk animation
        animator.SetTrigger("Attack");

        //detect enemies in range of atk
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //damage enemies
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("we Hit" + enemy.name);
        }
    }

    void StopAttack()
    {
        animator.Play("Player1Idle");
    }
}

void OnDrawGizmosSelected()
{
    if (attackPoint == null)
        return;

    Gizmos.DrawWireSphere(attackPoint.position, attackRange);     
}
