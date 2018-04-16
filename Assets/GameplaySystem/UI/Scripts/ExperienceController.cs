using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
public class ExperienceController : MonoBehaviour {

    [SerializeField]
    private Image radial;

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
        radial.fillAmount = 0.5f;
    }
}
