using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

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

    public int point;

    SoundManager soundManager;
    public FuelBar fuelBar;

    public int currentFuel;
    public int maxFuel = 100;
    public int lives;

    public GameObject camera;
    public GameObject playerSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sets lives

        //sets fuel
        currentFuel = maxFuel;
        fuelBar.SetMaxFuel(maxFuel);
        // finds the current sound manager in the scene
        soundManager = GameObject.FindWithTag("Audio").GetComponent<SoundManager>();
        camera = GameObject.FindWithTag("MainCamera");
        playerSpawn = GameObject.FindWithTag("SpawnPoint");
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
        if (collision.CompareTag("enemy") || collision.CompareTag("floor"))
        {
            camera.transform.position = playerSpawn.transform.position;
        }
    }
    IEnumerator Points()
    {
        while (true) 
        {
            yield return new WaitForSeconds(1);
            point += 10;
            currentFuel-= 2;
            fuelBar.SetFuel(currentFuel);
            Debug.Log(point);
            yield return null;
        }
        
    }
}
