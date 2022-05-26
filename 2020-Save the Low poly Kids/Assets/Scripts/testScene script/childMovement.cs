using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class childMovement : MonoBehaviour
{
    NavMeshAgent agent;
   [SerializeField] Transform[] destPoints=null;
    Vector3 destination;
    childCOntroller controller;
    Transform player;
    [SerializeField] Transform[] houses = null;
    int houseid;
   public static float Health = 100;
    bool seen = false;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination =destPoints[Random.Range(0,destPoints.Length)].position;
        player = GameObject.FindGameObjectWithTag("hazmat").GetComponent<Transform>();
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Vector3.Distance(transform.position,player.position)<=5|| childHealth.treated==true)
        {
            float dist = Vector3.Distance(transform.position, houses[0].position);
           /* for (int i=0;i<houses.Length;i++)
            {
               float tempdist = Vector3.Distance(transform.position, houses[i].position);
                if (dist >= tempdist)
                    dist = tempdist;
                houseid = i;
                    
            }*/
           //if (Health > 5)
            
                houseid = Random.Range(0, houses.Length);
                destination = (houses[houseid].position);
                //agent.speed = 15;
                seen = true;
               // Destroy(gameObject, 3);
                Debug.Log("reached home");
                
            

        }
       // if(childHealth.treated==true)
        //{
       //     agent.speed = 19;
       // }
       
        
            agent.SetDestination(destination);
        
        if (agent.remainingDistance <= agent.stoppingDistance && Health>0)
        {
            if(seen==false)
            nextdest();
        }
    }
    void nextdest()
    {
        destination = destPoints[Random.Range(0, destPoints.Length)].position;
        
    }
}
