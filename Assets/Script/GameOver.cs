using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void loadScene()
    {
        SceneManager.LoadScene("GameOver");
    }
        
    // Update is called once per frame
    void Update()
    {
        if (ScoreManager.Score < 0)
        {
            loadScene();
        }
    }
}
