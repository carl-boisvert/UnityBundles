using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Rat", menuName = "Enemy/Rat", order = 1)]
public class Rat : Enemy {

    private void Attack()
    {
        EventDelegate.OnAttackEvent(attack);
    }
}
