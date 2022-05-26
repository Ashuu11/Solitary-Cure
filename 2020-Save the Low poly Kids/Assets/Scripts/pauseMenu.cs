using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseCanvas = null;
    private void Start()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            pause();
    }
    public void pause()
    {
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
    }
    public void resume()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
    }
    public void mainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("opening");
    }
    public void exit()
    {
        Application.Quit(1);
    }
}
