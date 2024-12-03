using UnityEngine;
using System.Collections;
public class Missile : MonoBehaviour
{
    public Player player;
    public bool flight = false;
    int random;
    Rigidbody2D rb;
    SoundManager soundManager;
    public bool destroyed = false;
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        rb = GetComponent<Rigidbody2D>();
        soundManager = GameObject.FindWithTag("Audio").GetComponent<SoundManager>();
        
    }
    private void Update()
    {
        if (destroyed == true)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            StartCoroutine("Launch");
        }

    }
    IEnumerator Launch()
    {
        while (random != 3)
        {
            random = Random.Range(3, 0);
            Debug.Log(random);
            yield return new WaitForSeconds(1);
        }
        flight = true;
        soundManager.PlaySFX("Thruster");
        rb.AddForce(new Vector2(0,500));
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
