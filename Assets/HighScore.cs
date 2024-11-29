using UnityEngine;

public class HighScore : MonoBehaviour
{
    public TMPro.TextMeshProUGUI UI;
    public Player player;
    string highScore;
    int highNumb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highScore = PlayerPrefs.GetString("highscore");
        UI.text = highScore;
    }

    
    void Update()
    {
        if (int.TryParse(highScore, out highNumb))
        {
            Debug.Log(highNumb);
            if (player.point >= highNumb)
            {
                highScore = player.point.ToString();
                UI.text = "HI: " + player.point.ToString();
                PlayerPrefs.SetString("highscore", highScore);
            }
            
        }
    }
}
