using UnityEngine;

public class CrouchController : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator;

    private float crouchHeight;
    private float originalHeight;
    private Vector3 originalCenter;
    private bool isCrouching = false;


    void Start()
    {
        controller = GetComponent<CharacterController>();  // Correct assignment
        originalCenter = controller.center;
        originalHeight = controller.height;
        crouchHeight = originalHeight / 2.00f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouching = !isCrouching;
            animator.SetBool("isCrouching", isCrouching);
            controller.height = isCrouching ? crouchHeight : originalHeight;
            controller.center = isCrouching ? new Vector3(0, 0.46f, 0) : new Vector3(0, 0.93f, 0);
        }
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W)) && isCrouching)
        {
            animator.SetBool("IsCrouchWalking", true);
        }
        else
        {
            animator.SetBool("IsCrouchWalking", false);
        }


    }
}