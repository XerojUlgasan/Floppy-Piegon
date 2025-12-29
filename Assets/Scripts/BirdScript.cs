using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public Camera cam;
    public float flapStrength;
    public float birdSpeed;
    public bool isAlive { get; set; } = true;

    private LogicScript logic;
    private float top, down, left, right;
    private float screenRation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        top = cam.transform.position.y + cam.orthographicSize;
        down = cam.transform.position.y - cam.orthographicSize;
        left = cam.transform.position.x - cam.orthographicSize * cam.aspect;
        right = cam.transform.position.x + cam.orthographicSize * cam.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && isAlive)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, flapStrength);
        }

        Vector3 self = gameObject.transform.position;

        if (self.y > top || self.y < down ||
            self.x < left || self.x > right)
        {
            logic.resetScore();
        }
    }   
}
