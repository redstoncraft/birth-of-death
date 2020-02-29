using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelOnButton : MonoBehaviour
{
    

    [SerializeField]
    KeyCode keyRestart;

    [SerializeField]
    KeyCode keyRestartPS;

    

    void Update()
    {
        if (Input.GetKey(keyRestart))
        {
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        
        if (Input.GetKey(keyRestartPS))
        {
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        


       

    }
}
