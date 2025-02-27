    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.SceneManagement;


    [RequireComponent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;

    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;
    private Animator animator;
    
    public AudioSource audioSource;
    public UnityEvent keypressEvent;
   

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
        thisTransform = transform;
        animator = GetComponent<Animator>();
    }

    private void Update()
    {

        ApplyGravity();
        //CheckGround();
        MoveCharacter();
        KeepCharacterOnXAxis();
        if (Input.GetButtonDown("Jump") && controller.isGrounded)

        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
        
        QuitGame();
    }

    private void ApplyGravity()
    {
        // Apply gravity when not grounded
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = 0f; // Reset velocity when grounded
        }

        // Apply the velocity to the controller
        controller.SimpleMove(velocity * Time.deltaTime);
    }
   // private void CheckGround()
   // {
    //    if (controller.isGrounded)
    //    {
    //        Debug.Log("I'm on the Ground ya turkey");
    //    }
   // }
  
    private void MoveCharacter()
    {
        // Horizontal movement
        //if (Input.GetButtonDown("Jump") )
        //{
       //     velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
       // }

      //  if (velocity.y <= 0f)
       // {
       //     animator.SetTrigger("Fall");
       // }
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);
       
     
      
    }
    

    private void KeepCharacterOnXAxis()
    {
        // Maintain character on the same z-axis position
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }

    private void StaminaFunction()
    {
        keypressEvent.Invoke();
    }

    public void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
   
}