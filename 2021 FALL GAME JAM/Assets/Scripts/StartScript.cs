using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    private Canvas startMenu;
    // Start is called before the first frame update
    void Start()
    {
        startMenu = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void beginGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void exitGame()
    {
        //startMenu.enabled = false;
        Application.Quit();
    }
    public void controlsGame()
    {
        SceneManager.LoadScene("ControlsScene");
    }
}
