using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    // keeps the sound manager in the scene
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

    public void FirstLevel()
    {
        SceneManager.LoadScene(1);
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
    }

    public void Quit() 
    {

    }
}
