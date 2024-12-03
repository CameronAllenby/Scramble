using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // virtual joystick/movment variables
    [SerializeField] private InputActionReference action;
    [SerializeField] private float speed;

    public ScriptObject data;
    // Projectiles
    public GameObject lazer;
    public GameObject bomb;
    // Where the projectiles spawn from
    public Transform projSpawn;
    public Vector3 spawn;


    SoundManager soundManager;
    public FuelBar fuelBar;

    public int currentFuel;
    public int maxFuel = 100;
    public int lives = 3;

    public GameObject mainCamera;
    public GameObject playerSpawn;
    public GameObject reaspawn;
    public GameObject player;
    public LevelManager levelManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sets lives

        //sets fuel
        currentFuel = maxFuel;
        fuelBar.SetMaxFuel(maxFuel);
        // finds the current sound manager in the scene
        soundManager = GameObject.FindWithTag("Audio").GetComponent<SoundManager>();
        levelManager = GameObject.FindWithTag("LevelManager").GetComponent<LevelManager>();
        mainCamera = GameObject.FindWithTag("MainCamera");
        playerSpawn = GameObject.FindWithTag("SpawnPoint");
        reaspawn = GameObject.FindWithTag("Respawn");
        player = GameObject.FindWithTag("Player");
        StartCoroutine("Points");
    }

    // Update is called once per frame
    void Update()
    {
        if (currentFuel > maxFuel) { currentFuel = 100; }
        spawn = new Vector3(projSpawn.position.x, projSpawn.position.y);
        // getting the joystick output
        Vector2 moveDirect = action.action.ReadValue<Vector2>();
        // moves the player
        transform.Translate(moveDirect * speed * Time.deltaTime);
        if (currentFuel == 0)
        {
            levelManager.Death();
        }
    }
    //spawn bomb
    public void BombLaunch()
    {
        Instantiate(bomb, spawn, Quaternion.identity);
    }
    //
    public void FireLazer()
    {
        Instantiate(lazer, spawn, Quaternion.identity);
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") || collision.CompareTag("Floor"))
        {
            levelManager.Death();
        }
    }

    IEnumerator Points()
    {
        while (true) 
        {
            yield return new WaitForSeconds(1);
            levelManager.point += 10;
            currentFuel-= 2;
            fuelBar.SetFuel(currentFuel);
            Debug.Log(levelManager.point);
            yield return null;
        }
        
    }
}
