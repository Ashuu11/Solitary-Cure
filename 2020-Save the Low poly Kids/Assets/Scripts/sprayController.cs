using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sprayController : MonoBehaviour
{
    GameObject[] childs;
    [SerializeField]float followDistance = 15f;
    int temp;
    
    bool canSpray = false;
    [SerializeField]GameObject sprayer;

    void Start()
    {
        childs = GameObject.FindGameObjectsWithTag("Child");
       
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < childs.Length; i++)
        {
            float idist = Vector3.Distance(transform.position, childs[i].transform.position);
            if (idist <= followDistance)
            {
                canSpray = true;
            }
              

        }
        if(canSpray=true && Input.GetMouseButtonDown(1))
        {
            sprayer.SetActive(true);
            Debug.Log("you are sparaying");
            StartCoroutine(stopSpray());
        }
        

    }
    IEnumerator stopSpray()
    {
        yield return new WaitForSeconds(3);
        canSpray = false;
        Debug.Log("Spraying is stopped");
        sprayer.SetActive(false);
    }
    
}
