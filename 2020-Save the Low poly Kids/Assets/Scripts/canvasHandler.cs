using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject win = null;
    [SerializeField] GameObject lose = null;
    void Start()
    {
        win.SetActive(false);
        lose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(player.gamePoint>=2020)
        {
            Time.timeScale = 0;
            win.SetActive(true);
        }
        if(player.gamePoint!=2020 && Timer.time<=0)
        {
            Time.timeScale = 0;
            lose.SetActive(true);
        }
    }
}
