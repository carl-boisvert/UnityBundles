using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    public class ProgressBarController : MonoBehaviour
    {

        [SerializeField]
        protected float maxValue = 100;
        [SerializeField]
        protected float currentValue = 100;
        protected RawImage ui;

        protected void UpdateUi()
        {
            float percent = currentValue / maxValue;
            float xValue = -((percent * 0.5f) - 0.5f);
            ui.uvRect = new Rect(xValue, 0f, 0.5f, 1f);
        }
    }
}