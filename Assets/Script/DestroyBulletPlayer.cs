using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBulletPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            ScoreManager.Instance.addScore(1);
            Destroy(gameObject);
        }
    }
}
