using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    public static bool running;
    [SerializeField] GameObject clickEffect = null;
    AudioSource audio;
    bool audioPlaying = false;
    //Vector3 targetPos;
    public static int gamePoint;
    [SerializeField] Text score ;
  //  public Text timeDisplay = null;
    int scoretodisplay;
  //  int time ;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.SetDestination(transform.position);
        audio = GetComponent<AudioSource>();
        gamePoint = 0;
     //   time = 600;
    }

    // Update is called once per frame
    void Update()
    {
        scoretodisplay = (int)gamePoint;
       // time -=(int) Time.deltaTime;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {
          
            if(Physics.Raycast(ray,out hit,1000))
             {
              navMeshAgent.SetDestination(hit.point) ;
            }
            
            Instantiate(clickEffect, hit.point,transform.rotation);
        }
        if (navMeshAgent.velocity.sqrMagnitude > Mathf.Epsilon)
        {
            transform.rotation = Quaternion.LookRotation(navMeshAgent.velocity.normalized);
        }
        if (navMeshAgent.remainingDistance<=navMeshAgent.stoppingDistance)
        {
            running = false;
            audio.Stop();
            audioPlaying = false;
        }
        else
        {
            running = true;
            if (audioPlaying == false)
            {
                audio.Play();
                audioPlaying = true;
            }
        }

        score.text = scoretodisplay.ToString("0");
      //  timeDisplay.text = time.ToString();
    }       
}
