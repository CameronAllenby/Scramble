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
        if (col.CompareTag("Projectle"))
        {
            if (Missile.flight == false)
            {
                Missile.player.levelManager.point += 50;
            }
            if (Missile.flight == true)
            {
                Missile.player.levelManager.point += 80;
                Debug.Log("80 Points");
            }
            Destroy(gameObject);
        }

        if (col.CompareTag("Player"))
        {
            StartCoroutine("Launch");
        }
        if (col.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}
