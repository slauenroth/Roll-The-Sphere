using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayTime : MonoBehaviour
{

    float playTime;

    public bool isStopped;

    public TextMeshProUGUI uiText;

    // Start is called before the first frame update
    void Start()
    {
        isStopped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStopped) {
            playTime += Time.deltaTime;
            DisplayText(playTime);
        }
    }

    void DisplayText(float timeToDisplay) {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        uiText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
