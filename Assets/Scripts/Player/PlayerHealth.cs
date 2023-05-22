using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Header("Stats")]
    public int health;
    //public int startingHealth = 100;
    //public int currentHealth;

    [Header("Health Slider")]
    public Slider healthSlider;
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);


    PlayerMovement playermovement;
    bool isDead;
    bool damaged;

    public void TakeDamage(int damage)
    {
        damaged = true;

        health -= damage;

        healthSlider.value = health;

        if (health <= 0 && !isDead)
            Death();
    }

    //void Awake()
    //{
    //    playermovement = GetComponent<PlayerMovement>();
    //    currentHealth = startingHealth;
    //}

    // Update is called once per frame
    void Update()
    {
        if (damaged && damageImage != null) // Check if damageImage is not null before accessing it
        {
            damageImage.color = flashColour;
        }
        else if (damageImage != null) // Check if damageImage is not null before accessing it
        {
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }

    //public void TakeDamage(int amount)
    //{
    //    damaged = true;

    //    currentHealth -= amount;

    //    healthSlider.value = currentHealth;

    //    if (currentHealth <= 0 && !isDead)
    //    {
    //        Death();
    //    }
    //}

    void Death()
    {
        isDead = true;
        Time.timeScale = 0f;
        SceneManager.LoadScene("MainMenu");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}