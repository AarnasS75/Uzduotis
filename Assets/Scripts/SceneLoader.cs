using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader: MonoBehaviour
{
    public void Load(int levelNumber)
    {
        SceneManager.LoadScene(levelNumber);
    }
    public int GetSceneIndex()
    {
        return SceneManager.GetActiveScene().buildIndex - 1;
    }
}
