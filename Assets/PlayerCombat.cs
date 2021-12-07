using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

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
        //damage enemies
    }

    void StopAttack()
    {
        animator.Play("Player1Idle");
    }
}
