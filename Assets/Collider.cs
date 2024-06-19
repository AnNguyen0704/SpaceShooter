using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    [SerializeField] private ParticleSystem vfxExplosion;
    [SerializeField] private GameObject EnemyImage;
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
            StartCoroutine(playVfxExplosion());
        }
        else if(other.gameObject.CompareTag("Ground")){
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
}

