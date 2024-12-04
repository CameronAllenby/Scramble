using UnityEngine;
using System.Collections;
using UnityEditorInternal;
public class Missile : MonoBehaviour
{
    public Player player;
    public bool flight = false;
    int random;

    SoundManager soundManager;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        soundManager = GameObject.FindWithTag("Audio").GetComponent<SoundManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Projectle"))
        {
            if (flight == false)
            {
                player.levelManager.point += 50;
            }
            if (flight == true)
            {
                player.levelManager.point += 80;
                Debug.Log("80 Points");
            }
            Destroy(gameObject);
        }
    }
}
