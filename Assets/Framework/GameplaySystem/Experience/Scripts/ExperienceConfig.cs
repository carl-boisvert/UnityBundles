using System;
using System.Collections.Generic;
using UnityEngine;
using Snappydue.UnityBundle;

namespace Snappydue.UnityBundle
{
    [CreateAssetMenu(fileName = "ExperienceConfig", menuName = "Experience/ExperienceConfig", order = 2)]
    public class ExperienceConfig : ScriptableObject
    {
        [Serializable]
        public class LevelConfig
        {
            public int level;
            public int xp;
        }

        [SerializeField]
        public List<LevelConfig> levels = new List<LevelConfig>();

    }
}
