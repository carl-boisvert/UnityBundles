using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class EventDelegate
{
    public delegate void AttackHandler(int attack, string status);
    public static event AttackHandler AttackEvent;
    public static void OnAttackEvent(int attack, string status = null)
    {
        if (AttackEvent != null)
        {
            AttackEvent(attack, status);
        }
    }
}

[RequireComponent(typeof(Animator))]
public class EnemyController : MonoBehaviour {

    [SerializeField]
    private Enemy enemy;
    private float lastAttack;
    private Animator animator;    

	// Use this for initialization
	void Start () {
        lastAttack = 0;
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = enemy.AnimatorController;
    }
	
	// Update is called once per frame
	void Update () {
        if (lastAttack + Time.deltaTime > enemy.AttackSpeed)
        {
            //Attack
            EventDelegate.OnAttackEvent(enemy.Attack, "");
            animator.SetTrigger("Attack");
            lastAttack = 0;
        }
        else
        {
            lastAttack += Time.deltaTime;
        }
	}
}
