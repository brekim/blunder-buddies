using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float totalTime = 121;

    void Update()
    {
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(totalTime / 60);
            int seconds = Mathf.FloorToInt(totalTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            totalTime = 0;
            timerText.text = "You Lose";
        }
    }
}
