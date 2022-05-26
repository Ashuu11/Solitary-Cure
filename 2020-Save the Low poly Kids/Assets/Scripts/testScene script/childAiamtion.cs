using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class childAiamtion : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent navMeshAgent;
    bool running;
    Animator anim;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            running = false;
        }
        else
        {
            running = true;
        }
        anim.SetBool("running", running);
    }
}
