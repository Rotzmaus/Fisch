using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class ballspawnscript : MonoBehaviour
{
    public GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball != null)
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                float x = Random.Range(-1.0f, 1.0f);
                Vector3 position = transform.position + new Vector3(x, 0.0f, 0.0f);
                GameObject huansohn = Instantiate(ball, position, Quaternion.identity);
            }
        }
    }
}
