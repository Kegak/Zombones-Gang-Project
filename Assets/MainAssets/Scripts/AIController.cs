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
    AudioSource groan;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        destination = GameObject.FindGameObjectWithTag("Player");
        
        agent = GetComponent<NavMeshAgent>();

        groan = GetComponent<AudioSource>();

        animator = GetComponent<Animator>();
    }

    void Update() 
    {
        targetPos = destination.transform.position;
        targetDist = Vector3.Distance(targetPos, transform.position);

        Debug.Log(targetDist);

        if(targetDist < 15)
        {
            agent.SetDestination(destination.transform.position);
            PlaySound();
            animator.SetFloat("forward", 1.0f);
        }

        else
        {
            agent.isStopped = true;
            agent.ResetPath();
            groan.Stop();
            animator.SetFloat("forward", 0.0f);

            // TODO - Set idle animation here as well
        }
        if (targetDist <= agent.stoppingDistance)
        {
            animator.SetFloat("forward", 1.0f);
            FaceTarget();
        }

    }

    void PlaySound()
    {
        if (!groan.isPlaying)
        {
            groan.Play();
        }
    }

    void FaceTarget()
    {
        Vector3 direction = (targetPos - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,targetDist);
    }

}
