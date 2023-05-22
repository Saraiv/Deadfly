
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [Header("Stats")]
    public int health;
    public int scoreValue = 1;
    ScoreManager sm;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            ScoreManager.score += scoreValue;
            Destroy(gameObject);
        }


    }
}