using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEnemies2 : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public float stopDistance = 0.1f;
    public float rotateSpeed = 200f;
    private float timeInterval = 5.0f;
    private bool isFinished = false;
    private float timer;

    private bool isActive;
    private void Awake()
    {
        target = FindObjectOfType<Move>().transform;
        StartCoroutine(destroyObject());
    }
    // Start is called before the first frame update
    private void OnEnable()
    {
        isActive = true;
    }
    private void OnDisable()
    {
        isActive = false;
    }

    private void Update()
    {
        if (isFinished)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            return;
        }
        timer += Time.deltaTime;

        if (timer >= timeInterval)
        {
            target = null;
            isFinished = true;
        }
        if (isActive && target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;

            float distance = Vector3.Distance(transform.position, target.position);

            // Rotate towards the target
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
            Quaternion targetRotation = Quaternion.Euler(0, 0, angle);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);

            // Move towards the target if not yet reached
            if (distance > stopDistance)
            {
                transform.position += transform.up * speed * Time.deltaTime;
            }
            else
            {
                transform.position = target.position;
                isActive = false;
                
                Destroy(gameObject);
                
            }

        }


    }
    private IEnumerator destroyObject()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
        
    }
}
