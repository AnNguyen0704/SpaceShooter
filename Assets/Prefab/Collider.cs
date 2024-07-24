using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    [SerializeField] private bool spawnBullet;
    [SerializeField] private ParticleSystem vfxExplosion;
    [SerializeField] private GameObject EnemyImage;
    [SerializeField] private GameObject BulletEnemiesPrefab;
    private float timeSpawn = 2f;
    private float timer;
    [SerializeField] private Transform spawnerObject;

    // Start is called before the first frame update
    void Start()
    {
        // Hello its me, Quangcrazymen 
        spawnerObject = GameObject.FindGameObjectWithTag("SpawnerBullet").transform;
        spawnBulletEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeSpawn && spawnBullet)  {
            
            spawnBulletEnemies();
             timer = 0;
        }
            
    }
    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(playVfxExplosion());
            HealthBar.Instance.SetHealth(-10);
            

        }
        else if (other.gameObject.CompareTag("BulletPlayer"))
        {
            ScoreManager.Instance.addScore(1);

            StartCoroutine(playVfxExplosion());
            


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
    private void spawnBulletEnemies()
    {
        
        GameObject Bullet = Instantiate(BulletEnemiesPrefab, transform.position, Quaternion.identity, spawnerObject);
        Bullet.SetActive(true);
    }
}

