using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDataBase
{
    //[SerializeField] TextMeshProUGUI timeText;
    public static float remainingTime = 600f;
    public static bool puzzle1 = false;
    public static bool puzzle1Won = false;

    //private void Update()
    //{
    //    remainingTime -= Time.deltaTime;
    //    int minutes = Mathf.FloorToInt(remainingTime / 60);
    //    int seconds = Mathf.FloorToInt(remainingTime % 60);
    //    timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    //    if (remainingTime <= 0)
    //    {
    //        Debug.Log("Game Over");
    //    }
    //}
}
