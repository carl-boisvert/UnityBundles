using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snappydue.UnityBundle
{
    public class AttackController : MonoBehaviour
    {
        private Attack[] attacks;

        public void SetAttacks(Attack[] attacks)
        {
            this.attacks = attacks; 
        }

        // For the moment it returns a random attack, but it should be more intelligent
        public Attack SelectAttack()
        {
            int index = Random.Range(0, attacks.Length);
            Debug.Log("Attack by: " + attacks[index].AttackName);
            return attacks[index];
        }
        
    }
}