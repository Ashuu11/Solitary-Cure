using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float panspeed = 20f;
    public float scrollSpeed = 2;
    public Vector2 panlimit;
    
    void Update()
    {
        Vector3 pos = transform.position;
        if(Input.GetKey("w"))
        {
           //if (transform.position.z > -90 || transform.position.x <= 130)
                pos.z += panspeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
           // if (transform.position.z > -90 || transform.position.x <= 130)
                pos.z -= panspeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
           // if(transform.position.x >-140 || transform.position.x<=160)
            pos.x += panspeed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
           // if (transform.position.x > -140 || transform.position.x <= 160)
                pos.x -= panspeed * Time.deltaTime;
        }

        pos.x = Mathf.Clamp(pos.x, -panlimit.x, panlimit.y);
        pos.z = Mathf.Clamp(pos.z, -panlimit.y, panlimit.y);
       
        
        transform.position = pos;
    }
}
