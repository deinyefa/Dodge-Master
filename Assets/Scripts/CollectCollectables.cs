using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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
    }
}
