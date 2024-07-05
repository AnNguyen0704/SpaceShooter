using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    [SerializeField] private ParticleSystem vfxExplosion;
    [SerializeField] private GameObject EnemyImage;
    [SerializeField] private GameObject BulletEnemiesPrefab;
    private float timeSpawn = 2f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
       // Hello its me, Quangcrazymen 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeSpawn) {
           
            timer = 0;
        }
            
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            StartCoroutine(playVfxExplosion());
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(playVfxExplosion());
            other.GetComponent<Move>().currentHealth -= 20;
            other.GetComponent<Move>().healthBar.SetHealth(other.GetComponent<Move>().currentHealth);
            Destroy(gameObject);

        }
    }
    IEnumerator playVfxExplosion()
    {
        EnemyImage.gameObject.SetActive(false);
        vfxExplosion.Play();
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
        
    }
    void TakeDamage(int damage)
    {
        
    }
    private void bulletEnemies()
    {
        Instantiate(BulletEnemiesPrefab, transform.position, Quaternion.identity);
    }
}

