using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeController : MonoBehaviour
{

    FadeInOut fade;

    void Start()
    {
        fade = FindAnyObjectByType<FadeInOut>();

        fade.FadeOut();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
