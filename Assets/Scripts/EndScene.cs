using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    Collider2D col;
    public string scene;

    // Update is called once per frame
    void Update()
    {
        if (col.gameObject.name == "Player")
        {

            Load(scene);
        }
    }

    public void Load(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}