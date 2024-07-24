using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DemNguoc : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public float countDownTime = 60f;
    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = countDownTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimeText();
        }
        else
        {
            currentTime = 0;
            UpdateTimeText();
            TinhNang();

        }
    }
    void UpdateTimeText()
    {
        int minutes = ((int)currentTime/60);
        int seconds = ((int)currentTime%60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    void TinhNang()
    {
        if (ScoreManager.Score >= 10)
        {
            SceneManager.LoadScene("Win");
        }

        else if (ScoreManager.Score < 10)
        {
            SceneManager.LoadScene("GameOver");
        }




        
    }
    
}

