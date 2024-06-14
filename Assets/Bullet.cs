using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveVertical = speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y + moveVertical);


        
    }
}
