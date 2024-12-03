using UnityEngine;
using System.Collections;
public class Lazer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Missile Missile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(800, 0));

        StartCoroutine("DestroyLazer");
    }
    IEnumerator DestroyLazer()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        yield return null;
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
            Missile.destroyed = true;
        }
        if (col.CompareTag("Floor") || col.CompareTag("Enemy") )
        {
            Destroy(gameObject);
        }
    }
}
