// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class Timer : MonoBehaviour
// {
//     private float startTime;

//     //init timer variable
//     void Start()
//     {
//         //start counting time
//         startTime = Time.time;
//     }

//     void Update()
//     {
//         //update timer
//         // This is not necessary if you just want to print the elapsed time when the player enters the trigger
//     }

//     void OnTriggerEnter(Collider other)
//     {
//         if(other.CompareTag("Player"))
//         {
//             //print timer
//             float elapsedTime = Time.time - startTime;
//             Debug.Log("Elapsed time: " + elapsedTime + " seconds");
//         }
//     }
// }