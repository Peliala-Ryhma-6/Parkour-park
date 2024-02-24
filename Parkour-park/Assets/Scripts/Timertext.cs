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
        int minutes = (int) elapsedTime / 60;
        int seconds = (int) elapsedTime % 60;
        int milliseconds = (int) (elapsedTime * 1000) % 1000;

        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("000");
    }
    public string GetTimerText()
    {
        return timerText.text;
    }
}