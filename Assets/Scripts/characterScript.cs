using UnityEngine;
using UnityEngine.InputSystem;

public class characterScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject swinger;
    private Rigidbody2D rbSwing;
    public float speed;
    void Start()
    {
        swinger = GameObject.Find("Swinger");
        rb = GetComponent<Rigidbody2D>();
        rbSwing = swinger.GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        MovementInput();
    }
    
    void MovementInput()
    {
        Vector2 movement = new Vector2(0,0);
        if (Keyboard.current.wKey.isPressed) { movement += Vector2.up; }
        if (Keyboard.current.aKey.isPressed) { movement += Vector2.left; }
        if (Keyboard.current.dKey.isPressed) { movement += Vector2.right; }
        if (Keyboard.current.sKey.isPressed) { movement += Vector2.down; }
        movement.Normalize();
        movement *= speed;
        rb.AddForce(movement);
        rb.angularVelocity = 1;
    }
}
