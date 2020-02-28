using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform AttackPoint;
    public float attackRange = 1f;
    public LayerMask enemyLayers;

    public int attackDamage = 20;

    [SerializeField]
    KeyCode attack;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(attack))
        {
            Attack();

        }
    }

    void Attack()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, attackRange, enemyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
            return;

        Gizmos.DrawWireSphere(AttackPoint.position, attackRange);
    }


}
