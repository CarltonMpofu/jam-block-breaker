using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        // Debug.Log("Ball passed");
        SceneManager.LoadScene("GameOver");
    }
}
