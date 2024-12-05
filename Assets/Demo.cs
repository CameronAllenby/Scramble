using UnityEngine;
using UnityEngine.SceneManagement;

public class Demo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
