using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int newLevel = GameManager.CurrentLevel += 1;
            SceneManager.LoadScene("Level" + newLevel.ToString());
        }
    }
}
