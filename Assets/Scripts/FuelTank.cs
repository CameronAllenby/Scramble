using UnityEngine;

public class FuelTank : MonoBehaviour
{
    public Player player;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Projectle"))
        {
            player.currentFuel += 20;
            player.point += 150;
            Destroy(gameObject);
        }
    }
}
