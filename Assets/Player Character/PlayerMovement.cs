using UnityEngine; 

public class PlayerMovement : MonoBehaviour
{
     public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Vector2 movement;

    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Input detection should stay in Update for responsiveness
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right arrows
        movement.y = Input.GetAxisRaw("Vertical");   // W/S or Up/Down arrows
    }

    void FixedUpdate()
    {
        // Physics calculations should stay in FixedUpdate
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}