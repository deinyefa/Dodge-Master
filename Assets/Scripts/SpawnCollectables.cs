using UnityEngine;
using System.Collections;

public class SpawnCollectables : MonoBehaviour {

    public GameObject[] diamonds;
    public GameObject[] bombs;
    
    float minX, maxX;

	void Awake () {
        minX = -2.36f;
        maxX = 2.41f;
	}

    void Start() {
        StartCoroutine(SpawnDiamonds(1f));
        StartCoroutine(SpawnBombs(3f));
    }

    IEnumerator SpawnDiamonds (float time) {
        yield return new WaitForSecondsRealtime(time);

        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);

        Instantiate(diamonds[Random.Range(0, diamonds.Length)], temp, Quaternion.identity);

        StartCoroutine(SpawnDiamonds(Random.Range(1f, 2f)));
    }

    IEnumerator SpawnBombs(float time) {
        yield return new WaitForSecondsRealtime(time);

        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);

        Instantiate(bombs[Random.Range(0, bombs.Length)], temp, Quaternion.identity);

        StartCoroutine(SpawnBombs(Random.Range(2f, 4f)));
    }
}
