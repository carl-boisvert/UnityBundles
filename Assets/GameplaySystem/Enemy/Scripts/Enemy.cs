using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;



abstract public class Enemy : ScriptableObject{

    [SerializeField]
    protected string name;
    [SerializeField]
    protected int xp;
    [SerializeField]
    protected int attack;
    [SerializeField]
    protected int speed;
    [SerializeField]
    protected int stamina;
    [SerializeField]
    protected int health;
    [SerializeField]
    protected AnimatorOverrideController animatorController;
    [SerializeField]
    protected GameObject prefab;

    protected int baseSpeed = 100;

    public int Attack
    {
        get
        {
            return attack;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    public int Xp
    {
        get
        {
            return xp;
        }
    }


    public int AttackSpeed
    {
        get { return baseSpeed / speed; }
    }

    public int Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public int Stamina
    {
        get
        {
            return stamina;
        }

        set
        {
            stamina = value;
        }
    }

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public AnimatorOverrideController AnimatorController
    {
        get
        {
            return animatorController;
        }
    }

    public GameObject Prefab
    {
        get
        {
            return prefab;
        }

        set
        {
            prefab = value;
        }
    }
}
