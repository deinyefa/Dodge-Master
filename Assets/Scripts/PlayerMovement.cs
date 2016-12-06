using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5f;

    private float minX, maxX;
    private Rigidbody2D rigidBody;

	void Awake () {
        transform.position = new Vector3(0, -4.32f, 0);
        rigidBody = GetComponent<Rigidbody2D>();
	}

    void Start ()
    {
        Vector3 coor = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        minX = -coor.x + 0.4f;
        maxX = coor.x - 0.4f;
    }

    void Update() {
        Vector3 temp = transform.position;
        if (temp.x > maxX)
            temp.x = maxX;
        if (temp.x < minX)
            temp.x = minX;
        transform.position = temp;
    }
	
	void FixedUpdate () {
        Vector2 vel = rigidBody.velocity;
        vel.x = Input.GetAxis("Horizontal") * speed;
        rigidBody.velocity = vel;
	}
}
