using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int Score = 0;
    public TextMeshProUGUI scoreText;   
    // Start is called before the first frame update
    public static void addScore(int amount)
    {
        Score += amount;
    }
    public static void minusScore(int amount)
    {
        Score -= amount;
    }









    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:    " + Score;
    }
}
