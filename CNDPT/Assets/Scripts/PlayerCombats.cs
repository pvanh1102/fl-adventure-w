using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombats : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public int attackDamage = 40;
    public LayerMask enemyLayers;
    public float attackRate = 2f;
    public float nextAttackTime = 0f;
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime)//giới hạn thời gian tấn công lại
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                Attack();
                nextAttackTime= Time.time + 1f/attackRate;
            }

        }
        
        
    }
    void Attack()
    {
        //animation
        animator.SetTrigger("Attack");
        //Detect ranges
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        //damage
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Monster>().TakeDamage(attackDamage);
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
