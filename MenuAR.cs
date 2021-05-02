using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAR : MonoBehaviour
{
    void start(){
        Time.timeScale = 1;
    }

    public void buttonIPA()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
