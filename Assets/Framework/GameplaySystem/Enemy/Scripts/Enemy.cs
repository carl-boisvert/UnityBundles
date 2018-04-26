using UnityEngine;


namespace Snappydue.UnityBundle
{
    abstract public class Enemy : ScriptableObject
    {

        [SerializeField]
        protected string enemyName;
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
        private Attack[] attackList;
        [SerializeField]
        protected AnimatorOverrideController animatorController;
        [SerializeField]
        protected GameObject prefab;
        [TagSelector]
        public string[] distractedBy;
        [SerializeField]
        protected float distractionRadius;

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

        public Attack[] AttackList
        {
            get
            {
                return attackList;
            }
        }

        public float DistractionRadius
        {
            get
            {
                return distractionRadius;
            }
        }
    }
}