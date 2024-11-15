using UnityEngine;

public class camera : MonoBehaviour
{

    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(100, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
