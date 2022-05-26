using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem part;
    public static bool collided = false;
    
    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collided = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("collided");
        if(other.tag=="Child")
        {
            childMovement.Health += 30;
            childHealth.treated = true;
            childHealth.lifeTime += 20;
            Debug.Log("treated");
            collided = true;
        }
    }
}
