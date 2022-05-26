using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonOpening : MonoBehaviour
{
    public void credit()
    {
        SceneManager.LoadScene("Credits");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("opening");
    }
    public void start()
    {
        SceneManager.LoadScene("game");
    }
    public void tutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
    public void exit()
    {
        Application.Quit();
    }



}
