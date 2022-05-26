using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timer;
  public static  float time;
    void Start()
    {
        time = 300;
       // timer = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text=time.ToString("0");
    }
}
