using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointController : MonoBehaviour{

    [SerializeField]
    private int maxNumberOfCreature;
    [SerializeField]
    private int gizmosSize = 1;
    private int currentNumberOfCreature;
    private CheckpointController[] checkpoints;

	private void Start()
	{
        currentNumberOfCreature = 0;
        checkpoints = GetComponentsInChildren<CheckpointController>();
        Debug.Log(checkpoints.Length);
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

    public CheckpointController[] Checkpoints
    {
        get
        {
            return checkpoints;
        }
    }

    public bool HasPlaceAvaillable()
    {
        return currentNumberOfCreature < maxNumberOfCreature;
    }

	private void OnDrawGizmos()
	{
        Gizmos.color = Color.cyan;
        for (int i = 0; i < checkpoints.Length; i++)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawCube(checkpoints[i].transform.position, new Vector3(gizmosSize, gizmosSize, gizmosSize));
            if(i > 0)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawLine(checkpoints[i].transform.position, checkpoints[i - 1].transform.position);   
            }
        }
	}
}
