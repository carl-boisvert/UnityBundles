using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointController : MonoBehaviour{

    [SerializeField]
    private int maxNumberOfCreature;
    private int currentNumberOfCreature;

	private void Start()
	{
        currentNumberOfCreature = 0;
	}

	public int MaxNumberOfCreature
    {
        get
        {
            return maxNumberOfCreature;
        }
    }

    public int CurrentNumberOfCreature
    {
        get
        {
            return currentNumberOfCreature;
        }

        set
        {
            currentNumberOfCreature = value;
        }
    }

    public bool HasPlaceAvaillable()
    {
        return currentNumberOfCreature < maxNumberOfCreature;
    }
}
