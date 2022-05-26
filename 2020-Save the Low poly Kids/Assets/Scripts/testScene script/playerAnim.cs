using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnim : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if(player.running==true)
        {
            anim.SetBool("Run", true);
        }
        if (player.running == false)
        {
            anim.SetBool("Run",false);
        }

    }
}
