using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    [CreateAssetMenu(fileName = "KillObjective", menuName = "Objectives/KillObjective", order = 2)]
    public class KillObjective : Objective
    {

        [SerializeField]
        private int count;
        [SerializeField]
        private GameObject target;

        private void OnEnable()
        {

        }

        public override bool isCompleted()
        {
            throw new NotImplementedException();
        }

        private void OnEnnemyKilled()
        {

        }
    }
}