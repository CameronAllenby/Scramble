using UnityEngine;

public class Missile : MonoBehaviour
{
    public Player player;
    bool flight = false;
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
            }
            Destroy(gameObject);
        }


    }
}
