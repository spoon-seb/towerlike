using UnityEngine;

public class movement : MonoBehaviour
{
   
    private float horizontal;
        private float speed = 8f;
    }private float JumpingPower = 16f;
    private bool isFacingRight = true;

[SerializeField] private Rigidbody2D rb;
[SerializeField] private Transform groundCheck;
[SerializeField] private LayerMask GroundLayer;
    // Update is called once per frame
    void Update()
    {
       horizontal = Input.GetAxisRaw() 
    }
}
