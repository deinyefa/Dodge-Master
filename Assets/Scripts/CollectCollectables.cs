using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

public class CollectCollectables : MonoBehaviour {

    int score;
    public Text scoreText;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Diamond")
        {
            score++;
            scoreText.text = score.ToString();
            Debug.Log("the score is " + score);
            Destroy(other.gameObject);
        }
        else if (other.tag == "Bomb")
        {
            Destroy(gameObject);
            ReloadScene();
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("Game");
    }
}
