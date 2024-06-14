using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       // Hello its me, Quangcrazymen 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
        else if(other.gameObject.CompareTag("Ground")){
            Destroy(gameObject);
        }
    }
}

