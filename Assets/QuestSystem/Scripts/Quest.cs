using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    [CreateAssetMenu(fileName = "Quest", menuName = "Quest", order = 2)]
    public class Quest : ScriptableObject
    {

        [SerializeField]
        private Objective[] objectives = null;
        [SerializeField]
        private string questName;
        [SerializeField]
        private Quest[] mustBeDone = null;

        public Objective[] Objectives
        {
            get
            {
                return objectives;
            }
        }

        public string QuestName
        {
            get
            {
                return questName;
            }
        }

        public Quest[] MustBeDone
        {
            get
            {
                return mustBeDone;
            }
        }
    }
}