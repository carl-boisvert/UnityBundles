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


        public delegate void NewQuestHandler(Quest quest);
        public static event NewQuestHandler NewQuestEvent;
        public static void OnNewQuestEvent(Quest quest)
        {
            if (NewQuestEvent != null)
            {
                NewQuestEvent(quest);
            }
        }
    }

    public class QuestManager : MonoBehaviour
    {

        private List<Quest> currentQuest;
        private List<Quest> doneQuests;

        // Use this for initialization
        void Start()
        {
            currentQuest = new List<Quest>();
            doneQuests = new List<Quest>();
            Quest quest = new Quest();
            quest.QuestName = "Kill Jenkins";
            EventDelegate.OnNewQuestEvent(quest);
        }

        private void OnEnable()
        {
            EventDelegate.NewQuestEvent += AddQuest;
        }

        private void OnDisable()
        {
            EventDelegate.NewQuestEvent -= AddQuest;
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


        void AddQuest(Quest quest)
        {

        }
    }
}