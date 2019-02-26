using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    public void Load(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
