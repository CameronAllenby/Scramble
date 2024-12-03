using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public TMPro.TextMeshProUGUI UI;
    LevelManager levelManager;
    private void Start()
    {
        levelManager = GameObject.FindWithTag("LevelManager").GetComponent<LevelManager>();
    }
    void Update()
    {
        UI.text = "SCORE: " + levelManager.point.ToString();
    }
}
