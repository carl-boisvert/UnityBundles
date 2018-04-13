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
    [SerializeField]
    private GameObject modelRoot;
    private float lastAttack;
    private Animator animator;

    public Enemy Enemy
    {
        get
        {
            return enemy;
        }

        set
        {
            enemy = value;
        }
    }

    // Use this for initialization
    void Start () {
        lastAttack = 0;
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = enemy.AnimatorController;
        Instantiate(enemy.Prefab, modelRoot.transform);
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
