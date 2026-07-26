using Unity.VisualScripting;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public float pushStrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 dir = rb.transform.position - transform.position;
            dir.Normalize();
            rb.AddForce(dir * pushStrength, ForceMode2D.Impulse);
        }
    }
}
