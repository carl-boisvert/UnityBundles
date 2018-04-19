using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snappydue.UnityBundle
{

    public partial class EventDelegate
    {

        public delegate void QuestFinishedHandler(Quest quest);
        public static event QuestFinishedHandler QuestFinishedEvent;
        public static void OnQuestFinishedEvent(Quest quest)
        {
            if (QuestFinishedEvent != null)
            {
                QuestFinishedEvent(quest);
            }
        }
    }

    public class QuestManager : MonoBehaviour
    {

        private Quest[] currentQuest;
        private Quest[] doneQuests;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            foreach (Quest quest in currentQuest)
            {
                bool questFinished = true;
                foreach (Objective obj in quest.Objectives)
                {
                    if (!obj.isCompleted())
                    {
                        questFinished = false;
                    }
                }

                if (questFinished)
                {
                }
            }

        }
    }
}