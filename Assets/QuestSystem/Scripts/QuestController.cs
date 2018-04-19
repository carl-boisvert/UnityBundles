using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    public class QuestController : MonoBehaviour
    {

        private Quest[] quests;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            foreach (Quest quest in quests)
            {
                foreach (Objective obj in quest.Objectives)
                {

                }
            }
        }
    }
}