using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{   
    public GameObject pauseMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            TogglePause();
        }
    }

    public void TogglePause() {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        Time.timeScale = pauseMenu.activeSelf ? 0.0f: 1.0f;
    }

    public void Reload () {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1.0f;
    }

    public void QuitGame () {
        Application.Quit();
    }
    
}
