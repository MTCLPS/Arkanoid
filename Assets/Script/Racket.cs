using UnityEngine;

public class Racket : MonoBehaviour {

    float speed = 15;

	void Update () {
        float v = Input.GetAxisRaw("Horizontal") * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(v, 0);
	}
}
