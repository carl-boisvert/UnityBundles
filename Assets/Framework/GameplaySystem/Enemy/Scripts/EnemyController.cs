using UnityEngine;

namespace Snappydue.UnityBundle
{

    public partial class EventDelegate
    {

        public delegate void AttackHandler(int attack, string status);
        public static event AttackHandler AttackEvent;
        public static void OnAttackEvent(int attack, string status)
        {
            if (AttackEvent != null)
            {
                AttackEvent(attack, status);
            }
        }
    }

    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(AttackController))]
    public class EnemyController : MonoBehaviour
    {

        [SerializeField, Tooltip("Enemy data to use")]
        private Enemy enemy;
        [SerializeField, Tooltip("The gameobject Model that is a child of this object.")]
        private GameObject modelRoot;
        private float lastAttack;
        private Animator animator;
        private AttackController attackController;
        private Transform target;
        private SpawnPointController spawnPoint;

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

        public SpawnPointController SpawnPoint
        {
            get
            {
                return spawnPoint;
            }

            set
            {
                spawnPoint = value;
            }
        }

        // Use this for initialization
        void Start()
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
            lastAttack = 0;
            attackController = GetComponent<AttackController>();
            attackController.SetAttacks(enemy.AttackList);
            animator = GetComponent<Animator>();
            animator.runtimeAnimatorController = enemy.AnimatorController;
            Instantiate(enemy.Prefab, modelRoot.transform);
            InitCheckpoints();
        }

        // Update is called once per frame
        void Update()
        {
            float distance = Vector3.Distance(this.transform.position, target.position);

            if (distance <= enemy.DistractionRadius)
            {
                if (lastAttack + Time.deltaTime > enemy.AttackSpeed)
                {
                    //Attack
                    EventDelegate.OnAttackEvent(attackController.SelectAttack().Damage, "");
                    animator.SetTrigger("Attack");
                    lastAttack = 0;
                }
                else
                {
                    lastAttack += Time.deltaTime;
                }
            }
        }

        private void InitCheckpoints()
        {
            PatrolBehavior patrol = animator.GetBehaviour<PatrolBehavior>();
            if (patrol)
            {
                patrol.Checkpoints = spawnPoint.Checkpoints;
            }
            else
            {
                Debug.Log("Can't find the PatrolBehavior");
            }   
        }

		private void OnDrawGizmosSelected()
		{
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.transform.position, enemy.DistractionRadius);
		}
	}
}