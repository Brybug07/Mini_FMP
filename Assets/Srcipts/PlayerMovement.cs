using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed of the player movement
    private Rigidbody2D rb; // Reference to the Rigidbody2D component

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the player
    }

    private void Update()
    {
        // Get input from WASD or arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a new movement vector
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Normalize the movement vector to maintain consistent speed
        rb.velocity = movement.normalized * moveSpeed;
    }
}
