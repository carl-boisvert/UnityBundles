using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GetItemObjective", menuName = "Objectives/GetItemObjective", order = 2)]
public class GetItemObjective : Objective {

    private int count;
    private GameObject target;

    public override bool isCompleted()
    {
        throw new NotImplementedException();
    }
}
