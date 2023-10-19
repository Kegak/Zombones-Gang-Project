using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{

    private GameObject destination;
    private NavMeshAgent agent;
    private Vector3 targetPos;
    private float targetDist;

    // Start is called before the first frame update
    void Start()
    {
        destination = GameObject.FindGameObjectWithTag("Player");
        
        agent = GetComponent<NavMeshAgent>();
    }

    void Update() 
    {
        targetPos = destination.transform.position;
        targetDist = Vector3.Distance(targetPos, transform.position);

        Debug.Log(targetDist);

        if(targetDist < 15)
        {
            agent.SetDestination(destination.transform.position);
        }

        else
        {
            agent.isStopped = true;
            agent.ResetPath();

            // TODO - Set idle animation here as well
        }
    }
}
