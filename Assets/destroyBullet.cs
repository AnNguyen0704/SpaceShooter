using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class destroyBullet : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("DestroyBullet"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            ScoreManager.addScore(1);
        }


    }
}
