using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeaponController : MonoBehaviour
{
    public GameObject MeleeWeapon;
    public bool canAttack = true;
    public float attackCooldown = 1.0f;
    //public AudioClip MeleeAttackSound;


    public bool isAttacking = false;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(canAttack)
            {
                MeleeAttack();
            }
        }
    }

    public void MeleeAttack()
    {
        isAttacking = true;
        canAttack = false;
        Animator anim = MeleeWeapon.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        //AudioSource ac = GetComponent<AudioSource>();
        //ac.PlayOneShot(MeleeAttackSound);
        StartCoroutine(ResetAttackCooldown());
    }


    IEnumerator ResetAttackCooldown() 
    {
        StartCoroutine(ResetAttackBool()); 
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }

    IEnumerator ResetAttackBool()
    {
        yield return new WaitForSeconds(1.0f);
        isAttacking = false;
    }

}
