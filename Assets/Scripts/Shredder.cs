using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Diamond")
            Destroy(other.gameObject);
    }
}
