using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System.Collections;

public class Player : MonoBehaviour
{
    // virtual joystick/movment variables
    [SerializeField] private InputActionReference action;
    [SerializeField] private float speed;

    // Projectiles
    public GameObject lazer;
    public GameObject bomb;
    // Where the projectiles spawn from
    public Transform projSpawn;
    public Vector3 spawn;

    public int point;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
            Debug.Log(point);
            yield return null;
        }
        
    }
}
