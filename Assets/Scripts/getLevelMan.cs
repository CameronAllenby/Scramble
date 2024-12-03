using UnityEngine;
using UnityEngine.SceneManagement;

public class getLevelMan : MonoBehaviour
{
    SoundManager soundManager;
    LevelManager levelManager;
    private void Start()
    {
        soundManager = GameObject.FindWithTag("Audio").GetComponent<SoundManager>();
        levelManager = GameObject.FindWithTag("LevelManager").GetComponent<LevelManager>();
    }
    public void FirstLevel()
    {
        SceneManager.LoadScene(1);
        soundManager.PlayMusic("MainTheme");
        levelManager.point = 0;

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        soundManager.PlayMusic("Title");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
