using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Snappydue.UnityBundle
{
    public class PatrolBehavior : StateMachineBehaviour
    {
        [SerializeField]
        private CheckpointController[] checkpoints;
        [SerializeField]
        private int stopRadius = 5;
        private int currentCheckpointIndex = 0;

        public CheckpointController[] Checkpoints
        {
            get
            {
                return checkpoints;
            }

            set
            {
                checkpoints = value;
            }
        }

        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            
        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
            float distance = Vector3.Distance(animator.gameObject.transform.position, checkpoints[currentCheckpointIndex].transform.position);
            if (distance > stopRadius)
            {
                Vector3 newPosition = Vector3.MoveTowards(animator.gameObject.transform.position, checkpoints[currentCheckpointIndex].transform.position, 100 * Time.deltaTime);
                Debug.Log("Current position: "+ animator.gameObject.transform.position.ToString() + " Moving to: " + newPosition.ToString() + " or " + checkpoints[currentCheckpointIndex].name);
                animator.gameObject.transform.position = newPosition;
            }
            else
            {
                if (currentCheckpointIndex < checkpoints.Length - 1)
                {
                    currentCheckpointIndex++;
                }
                else
                {
                    currentCheckpointIndex = 0;
                }
            }
        }

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //
        //}

        // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
        override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
           
        }

        // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
        //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //
        //}
    }
}