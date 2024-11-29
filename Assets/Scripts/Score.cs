using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public TMPro.TextMeshProUGUI UI;
    public Player player;
    void Update()
    {
        UI.text = "SCORE: " + player.point.ToString();
    }
}
