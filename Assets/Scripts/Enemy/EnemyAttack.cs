using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    public int damage;

    private Rigidbody rb;

    [Header("Settings")]
    private float timer;
    public float timeBetweenAttacks;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerHealth player = collision.gameObject.GetComponent<PlayerHealth>();

            if (timer >= timeBetweenAttacks)
            {
                player.TakeDamage(damage);
                timer = 0f;
            }
        }
    }

    //public float timeBetweenAttacks = 0.5f;
    //public int attackDamage = 10;

    //GameObject player;
    //PlayerHealth playerHealth;
    //bool playerInRange;
    //float timer;

    //private void Awake()
    //{
    //    player = GameObject.FindGameObjectWithTag("Player");
    //    playerHealth = player.GetComponent<PlayerHealth>();

    //}

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject == player)
    //    {
    //        playerInRange = true;
    //    }
    //}

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject == player)
    //    {
    //        playerInRange = false;
    //    }
    //}
    //// Start is called before the first frame update


    //// Update is called once per frame
    //void Update()
    //{
    //    timer += Time.deltaTime;

    //    if (timer >= timeBetweenAttacks && playerInRange/* && enemyHealth.currentHealth>0*/)
    //    {
    //        Attack();
    //    }

    //}

    //void Attack()
    //{
    //timer = 0f;
    //if (playerHealth.currentHealth > 0)
    //{
    //    playerHealth.TakeDamage(attackDamage);
    //}
    //}
}