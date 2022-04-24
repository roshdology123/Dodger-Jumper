using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    float horizontalInput = 0f;
    float verticalInput = 0f;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 4f;
    bool OnGround = false;
    bool Jump = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump") && OnGround && !Jump)
        {
            Jump = true;
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
    }
    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.CompareTag("Ground") )
        {
            Debug.Log("I've Touched the ground");
            OnGround = true;
            Jump = false;
        }
        else { OnGround = false; }

    }

}
