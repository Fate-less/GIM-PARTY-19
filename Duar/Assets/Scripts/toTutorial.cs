using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toTutorial : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Player Teleported, Next Scene");
    }
}
