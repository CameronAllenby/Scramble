using UnityEngine;

public class FuelTank : MonoBehaviour
{
    public Player player;
    public SoundManager soundManager;
    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        soundManager = GameObject.FindWithTag("Audio").GetComponent<SoundManager>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Projectle"))
        {
            player.currentFuel += 20;
            player.levelManager.point += 150;
            soundManager.PlaySFX("Points");
            Destroy(gameObject);
        }
    }
}
