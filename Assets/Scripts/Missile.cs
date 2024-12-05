using UnityEngine;

public class Missile : MonoBehaviour
{
    public Player player;
    public bool flight = false;


    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        
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
