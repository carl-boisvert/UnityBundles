using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour{

    [SerializeField]
    protected string name;
    [SerializeField]
	protected int xp;
    [SerializeField]
    protected int attack;

    protected int Attack
    {
        get
        {
            return attack;
        }

        set
        {
            attack = value;
        }
    }
}
