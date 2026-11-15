using UnityEngine;

public class Ball : MonoBehaviour
{
public Rigidbody2D rb;
public float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = gameObject.GetComponent<Rigidbody2D>();
Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1f : 1f;
        float y = Random.Range(-0.7f, 0.7f);
        rb.linearVelocity = new Vector2(x, y).normalized * speed;
    }
}