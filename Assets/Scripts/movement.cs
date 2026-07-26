using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float rotateSpeed;
    private GameObject wixer;
    void Start()
    {
        wixer = GameObject.Find("Main Camera");
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {   
        
        wixer.transform.position = new Vector3(transform.position.x,transform.position.y,wixer.transform.position.z); //folgt position von spieler
        
        Vector2 victor = new Vector2(0, 0);
        if(Keyboard.current.wKey.isPressed){victor += Vector2.up;}
        if(Keyboard.current.sKey.isPressed){victor += Vector2.down;}
        if(Keyboard.current.aKey.isPressed){rb.angularVelocity += rotateSpeed;}
        if(Keyboard.current.dKey.isPressed){rb.angularVelocity += rotateSpeed*-1;}
        
        victor.Normalize();
        victor = transform.TransformDirection(victor);
        victor *= speed;
        rb.AddForce(victor);
    }
}
