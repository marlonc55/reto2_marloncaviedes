using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100; // Vida maxima del player
    public Slider healtSlider; //Referencia del Slider en salun UI

    public int currentHealth; //La vida actual del player

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void TakeDamage(int dameAmount)
    {
        currentHealth -= dameAmount;
        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            //El jugador a perdido
            //Reiniciar
        }

    }

    public void UpdateHealthUI()
    {
        healtSlider.value = currentHealth / (float)maxHealth;
    }

}
