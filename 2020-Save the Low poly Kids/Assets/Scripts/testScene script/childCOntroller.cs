using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class childCOntroller : MonoBehaviour
{
    [SerializeField] Transform[] instantiatePoints=null;
    float counter;
    float timePassing;
    [SerializeField] GameObject[] children=null;
   // public Transform[] destPoints=null;
   
    
    void Start()
    {
        counter = 5;
        timePassing = 1;
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime*timePassing;
        if(counter<=0)
        {
            counter = (Random.Range(10,20) );
            timePassing += 0.002f;
            childSpawn();

        }
    }
    void childSpawn()
    {
       // Debug.Log("we are into function");
        var randomInst = Random.Range(0, instantiatePoints.Length);
        var randomKid = Random.Range(0, children.Length);
        Instantiate(children[randomKid], instantiatePoints[randomInst].position, transform.rotation);
    }
}
