using UnityEngine;
using System.Collections;
public class Lazer : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(800,0));

        StartCoroutine("DestroyLazer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DestroyLazer()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        yield return null;
    }
}
