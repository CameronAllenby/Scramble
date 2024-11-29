using UnityEngine;

public class HighScoreDis : MonoBehaviour
{
    public TMPro.TextMeshProUGUI UI;
    void Start()
    {
        UI.text =  "HI: " + PlayerPrefs.GetString("highscore");
    }
}
