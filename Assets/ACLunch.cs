using UnityEngine;
using System.Collections;
public class ACLunch : MonoBehaviour
{
    int random;
    Rigidbody2D rb;
    SoundManager soundManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        soundManager = GameObject.FindWithTag("Audio").GetComponent<SoundManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine("Launch");
        }
    }
    IEnumerator Launch()
    {
        while (random != 4)
        {
            random = Random.Range(4, 0);
            yield return new WaitForSeconds(1);
        }
        soundManager.PlaySFX("Thruster");
        rb.AddForce(new Vector2(0, 500));
        Debug.Log("yes");
        yield return new WaitForSeconds(2);
        Debug.Log("no");
    }
}
