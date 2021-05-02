using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackHandler : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android && SceneManager.GetActiveScene().buildIndex == 3) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
        else if (Application.platform == RuntimePlatform.Android && SceneManager.GetActiveScene().buildIndex == 4) {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            }
        }
    }
}
