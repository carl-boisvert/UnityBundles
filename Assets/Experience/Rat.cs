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
public class Rat : Monster {

    private void Attack()
    {
        EventDelegate.OnAttackEvent(attack);
    }
}
