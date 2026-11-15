using UnityEngine;

public class Paddle : MonoBehaviour {
    public float speed = 5f;
    public bool player1;

    void Update() {
        float movement = 0f;

        if (player1) {
            if (Input.GetKey(KeyCode.W)) {
                movement = 1f;
            }
            if (Input.GetKey(KeyCode.S)) {
                movement = -1f;
            }
        } else {
            if (Input.GetKey(KeyCode.UpArrow)) {
                movement = 1f;
            }
            if (Input.GetKey(KeyCode.DownArrow)) {
                movement = -1f;
            }
        }

        transform.Translate(Vector3.up * movement * speed * Time.deltaTime);

        float Ylimit = Mathf.Clamp(transform.position.y, -4.2f, 4.2f);
        transform.position = new Vector3(transform.position.x, Ylimit, 0);
    }
}
