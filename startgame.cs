using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    public string LevelName;
    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelName);
        }
}