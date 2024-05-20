using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeB : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float time;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        int dk = Mathf.FloorToInt(time/60);
        int sn = Mathf.FloorToInt(time%60);
        timerText.text = string.Format("{0:00}:{1:00}",dk,sn);
    }
}
