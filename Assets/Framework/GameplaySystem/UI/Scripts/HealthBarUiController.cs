﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    public static partial class EventDelegate
    {
        public delegate void DeathHandler();
        public static event DeathHandler DeathEvent;
        public static void OnDeathEvent()
        {
            if (DeathEvent != null)
            {
                DeathEvent();
            }
        }
    }

    [RequireComponent(typeof(RawImage))]
    public class HealthBarUiController : ProgressBarController
    {

        private void Start()
        {
            ui = GetComponent<RawImage>();
        }

        private void OnEnable()
        {
            EventDelegate.AttackEvent += OnAttackEvent;
        }

        private void OnDisable()
        {
            EventDelegate.AttackEvent -= OnAttackEvent;
        }

        void OnAttackEvent(int attack, string status)
        {
            currentValue -= attack;
            UpdateUi();
        }
    }
}