using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;

    void Start()
    {
        LoadScene();
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}

