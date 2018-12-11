using UnityEngine;

public class Ball : MonoBehaviour {
    float speed = 10;

	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.down * 8;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Racket")
        {
            float dis = (transform.position.x - col.transform.position.x) / col.collider.bounds.size.y;
            GetComponent<Rigidbody2D>().velocity = new Vector2(-dis, 1).normalized * speed;
        }
        if (col.gameObject.tag == "Block")
            Destroy(col.gameObject);
    }
}
