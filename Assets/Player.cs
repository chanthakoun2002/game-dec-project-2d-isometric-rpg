using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){ //this if for testing Purposes
            TakeDamage(20);
        }
        
    }

    void TakeDamage(int damage){
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
