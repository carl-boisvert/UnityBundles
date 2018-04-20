using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Snappydue.UnityBundle
{
    [RequireComponent(typeof(Animator))]
    public class QuestUiLineController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {

        [SerializeField]
        private Text text;
        private Animator anim;

        private void Start()
        {
            anim = GetComponent<Animator>();
            anim.enabled = false;
        }


        public void SetQuest(Quest quest)
        {
            text.text = quest.QuestName;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            anim.enabled = true;
            anim.SetTrigger("OnPointerEnter");
        }


        public void OnPointerExit(PointerEventData eventData)
        {
            anim.SetTrigger("OnPointerExit");
        }
    }
}