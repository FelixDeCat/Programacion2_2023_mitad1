using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            agent.isStopped = false;
            agent.SetDestination(target.position);
        }
    }
}
