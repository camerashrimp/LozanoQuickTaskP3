using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f; // Speed of the player movement
    private Rigidbody2D rb; // Reference to the Rigidbody2D component

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontalInput, verticalInput) * speed;
        rb.linearVelocity = movement;
    }
}
