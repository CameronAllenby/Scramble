using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Rigidbody2D rb;
    public Missile Missile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        // gives movement to the bomb
        rb.AddForce(new Vector2(100, 50));
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Floor") || col.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
