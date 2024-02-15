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
        crouchHeight = originalHeight / 2;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouching = !isCrouching;
            animator.SetBool("isCrouching", isCrouching);
            controller.height = isCrouching ? crouchHeight : originalHeight;
            controller.center = new Vector3(0, controller.height / 2, 0);
        }


    }
}