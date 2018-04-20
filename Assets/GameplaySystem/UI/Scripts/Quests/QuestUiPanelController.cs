using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Snappydue.UnityBundle
{
    public class QuestUiPanelController : MonoBehaviour
    {

        [SerializeField]
        private GameObject questNamePrefabs;

        // Use this for initialization
        void Start()
        {

        }

        private void OnEnable()
        {
            EventDelegate.NewQuestEvent += AddQuest;
        }

        private void OnDisable()
        {
            EventDelegate.NewQuestEvent -= AddQuest;
        }

        void AddQuest(Quest quest)
        {
            GameObject questName = Instantiate(questNamePrefabs, this.transform);
            questName.GetComponent<QuestUiLineController>().SetQuest(quest);
        }
    }
}