using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract public class Objective : ScriptableObject {

    protected enum ObjectivesTypes { GetKill, GetItem, TalkTo };

    [SerializeField]
    private string objectiveName;
    [SerializeField]
    private ObjectivesTypes type;

    protected string ObjectiveName
    {
        get
        {
            return objectiveName;
        }
    }

    protected ObjectivesTypes Type
    {
        get
        {
            return type;
        }
    }

    abstract public bool isCompleted();
}
