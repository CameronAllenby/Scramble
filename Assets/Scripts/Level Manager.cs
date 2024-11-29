using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    SoundManager soundManager;
    public static LevelManager Instance;
    // keeps the level manager in the scene
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        soundManager = GameObject.FindWithTag("Audio").GetComponent<SoundManager>();
    }
    public void FirstLevel()
    {
        SceneManager.LoadScene(1);
        soundManager.PlayMusic("MainTheme");
    }

    public void SecondLevel() 
    { 
    }

    public void ThirdLevel() 
    {
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
