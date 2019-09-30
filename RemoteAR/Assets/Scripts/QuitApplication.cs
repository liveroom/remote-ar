using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitApplication : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Application quit
    public void QuitApp()
    {
        Application.Quit();
    }

    // Back to start view
    public void GotoStartView()
    {
        SceneManager.LoadScene("StartScene");
    }

}
