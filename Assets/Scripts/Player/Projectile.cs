using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage;
    public float despawnTimer;

    private Rigidbody rb;

    private bool targetHit;

    private float timer;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= despawnTimer)
            Destroy(gameObject);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth>();

            enemy.TakeDamage(damage);

            Destroy(gameObject);
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Enemy") 
    //    {
    //        EnemyHealth enemy = other.gameObject.GetComponent<EnemyHealth>();

    //        enemy.TakeDamage(damage);

    //        Destroy(gameObject);
    //    }

    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.GetComponent<Rigidbody>() != null)
    //    {
    //        PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
    //        EnemyHealth enemy = collision.gameObject.GetComponent<EnemyHealth>();

    //        enemy.TakeDamage(damage);

    //        Destroy(gameObject);
    //    }
    //}
}

