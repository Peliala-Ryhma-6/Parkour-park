using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaulting : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask vaultLayer;
    private float playerHeight = 1.8f;
    private float playerRadius = 0.28f;

     private Animator animator;

    void Start()
    {
          animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vault();
    }
    private void Vault()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Physics.Raycast(transform.position, transform.forward, out var firstHit, 1f, vaultLayer))
            {
                Debug.Log("Vaultable in front");
                animator.SetBool("IsClimbing", true);

                if (Physics.Raycast(firstHit.point + (transform.forward * playerRadius) + (Vector3.up * 0.6f * playerHeight), Vector3.down, out var secondHit, playerHeight))
                {
                    Debug.Log("found place to land");
                    StartCoroutine(LerpVault(secondHit.point, 0.5f));
                }
            }
        }

    }
    IEnumerator LerpVault(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.position;

        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;
        animator.SetBool("IsClimbing", false);
    }
}