using UnityEngine;

public class CrouchController : MonoBehaviour
{
    public CharacterController controller;
    public Animator animator;

    public float crouchHeight = 1.0f;
    private float originalHeight;
    private bool isCrouching = false;

    void Start()
    {
        originalHeight = controller.height;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouching = !isCrouching;
            animator.SetBool("isCrouching", isCrouching);
        }

        // float targetHeight = isCrouching ? crouchHeight : originalHeight;
        // controller.height = Mathf.Lerp(controller.height, targetHeight, Time.deltaTime * 10f);
    }
}