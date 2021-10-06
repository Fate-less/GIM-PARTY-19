using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toAmogus : MonoBehaviour
{
    public Vector2 playerPosition;
    public vectorValue playerStorage;
    void OnTriggerEnter2D(Collider2D other)
    {
        playerStorage.initialValue = playerPosition;    
        SceneManager.LoadScene(1);
        Debug.Log("Player Teleported, Next Scene");
    }
}
