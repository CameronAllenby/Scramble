using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine.UIElements;

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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        // finds the current sound manager in the scene
        soundManager = GameObject.FindWithTag("Audio").GetComponent<SoundManager>();
        StartCoroutine("Points");
    }

    // Update is called once per frame
    void Update()
    {
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
    IEnumerator Points()
    {
        while (true) 
        {
            yield return new WaitForSeconds(1);
            point = point + 10;
            data.currentFuel--;
            Debug.Log(point);
            yield return null;
        }
        
    }
}
