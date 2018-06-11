using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ControladorGeral))]
public class CharacterCombat : MonoBehaviour
{

    public float attackSpeed = 1f;
    private float attackCooldown = 0f;

    public float attackDelay = .6f;

    public event System.Action OnAttack;

    ControladorGeral myStats;

    void Start()
    {
        myStats = GetComponent<ControladorGeral>();
    }

    void Update()
    {
        attackCooldown -= Time.deltaTime;
    }

    public void Attack(ControladorGeral targetStats)
    {
        if (attackCooldown <= 0f)
        {
            //StartCoroutine(DoDamage(targetStats, attackDelay));

            if (OnAttack != null)
                OnAttack();

            attackCooldown = 1f / attackSpeed;
        }

    }
}