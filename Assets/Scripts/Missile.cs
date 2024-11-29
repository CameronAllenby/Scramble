using UnityEngine;
using System.Collections;
public class Missile : MonoBehaviour
{
    public Player player;
    bool flight = false;
    int random;
    Rigidbody2D rb;
    SoundManager soundManager;
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        rb = GetComponent<Rigidbody2D>();
        soundManager = GameObject.FindWithTag("Audio").GetComponent<SoundManager>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Projectle"))
        {
            if (flight == false)
            {
                player.point += 50;
            }
            if (flight == true)
            {
                player.point += 80;
                Debug.Log("80 Points");
            }
            Destroy(gameObject);
        }

        if (col.CompareTag("Player"))
        {
            StartCoroutine("Launch");
        }
        
    }
    IEnumerator Launch()
    {
        while (random != 5)
        {
            random = Random.Range(5, 0);
            Debug.Log(random);
            yield return new WaitForSeconds(1);
        }
        flight = true;
        soundManager.PlaySFX("Thruster");
        rb.AddForce(new Vector2(0,500));
        yield return new WaitForSeconds(2);
    }
}
