﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    [CreateAssetMenu(fileName = "TalkObjective", menuName = "Objectives/TalkObjective", order = 2)]
    public class TalkObjective : Objective
    {

        private GameObject target;

        public override bool isCompleted()
        {
            throw new NotImplementedException();
        }
    }
}