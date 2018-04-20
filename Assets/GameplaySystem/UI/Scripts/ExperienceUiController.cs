using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    public static partial class EventDelegate
    {
        public delegate void ExperienceHandler(int exp);
        public static event ExperienceHandler ExperienceEvent;
        public static void OnExperienceEvent(int exp)
        {
            if (ExperienceEvent != null)
            {
                ExperienceEvent(exp);
            }
        }
    }
    public class ExperienceUiController : MonoBehaviour
    {

        [SerializeField]
        private Image radial;
        [SerializeField]
        private ExperienceConfig xpConfig;
        [SerializeField]
        private int level;

        private void OnEnable()
        {
            EventDelegate.ExperienceEvent += OnExperienceEvent;
        }

        private void OnDisable()
        {
            EventDelegate.ExperienceEvent -= OnExperienceEvent;
        }

        private void OnExperienceEvent(int exp)
        {
            int xpMax = xpConfig.levels[level - 1].xp;
            float percent = (radial.fillAmount * xpMax) / xpMax;
            Debug.Log(percent);
            //radial.fillAmount = 0.5f;
        }
    }
}