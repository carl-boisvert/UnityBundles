using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Rat", menuName = "Monsters/Rat", order = 2)]
public class Rat : Enemy {

    private void Attack()
    {
        EventDelegate.OnAttackEvent(attack);
    }
}
