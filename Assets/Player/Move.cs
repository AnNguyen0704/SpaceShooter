using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public int currentHealth = 100;
    public float speed = 3.0f;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    public int maxHealth = 100;
    

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; 
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float moveHorizontal = Horizontal * speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x + moveHorizontal,  transform.position.y);


        float Vertical = Input.GetAxis("Vertical");
        float moveVertical = Vertical * speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y + moveVertical);


        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            
        }
        if(currentHealth == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("BulletEnemy"))
        {
            Debug.Log("co vao ham move");
            ScoreManager.Instance.minusScore(1);
            HealthBar.Instance.SetHealth(-10);
            Destroy(other);
            if (HealthBar.Instance.isOutOfHealth())
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GameOver");
            }
        }
    }

}
