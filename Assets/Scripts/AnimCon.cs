using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCon : MonoBehaviour
{
    private Animator animator = null;

    private bool isAttacking;

    private void Start()
    {
        animator = transform.GetComponent<Animator>();
    }

    private void OnAttack()
    {
        if (!isAttacking)
        {
            StartCoroutine(AttackRoutine());
        }
    }

    IEnumerator AttackRoutine()
    {
        animator.SetBool("Attack", true);
        isAttacking = true;

        yield return new WaitForSeconds(1.5f);

        animator.SetBool("Attack", false);
        isAttacking = false;
    }
}
