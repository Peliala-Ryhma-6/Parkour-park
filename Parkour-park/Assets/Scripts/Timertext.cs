using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float elapsedTime = Time.time - startTime;
        string minutes = ((int) elapsedTime / 60).ToString();
        string seconds = (elapsedTime % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }
}