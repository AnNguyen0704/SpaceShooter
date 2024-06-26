using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed*Time.deltaTime);
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }


    }
}
