using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour 
{
    [SerializeField] private int ContaminationValue; //reference to script and creating its variable
    [SerializeField] private Slider healthbarSlider;
    [SerializeField] private Image healthbarFillImage;
    [SerializeField] private Color maxHealthColor;
    [SerializeField] private Color zeroHealthColor;
    //[SerializeField] GameObject dieeffect = null;

    [SerializeField] private int MaxHealth = 100;
   // [SerializeField] private GameObject damageTextPrefab;

    private float currentHealth;   

    private void Start()
    {
       // currentHealth = MaxHealth;
        SetHealthBarUi();
        currentHealth = childMovement.Health;
       
    }

    private void Update()
    {
        currentHealth -= ContaminationValue * (int)Time.deltaTime; //reducing health as per damage from shooting 
        //Instantiate(damageTextPrefab, transform.position, Quaternion.identity).GetComponent<DamageText>().Initialise(damage); //spawns the health text above ui

        CheckIfDead();
        SetHealthBarUi();
    }

    private void CheckIfDead()
    {
        if(currentHealth <= 0)
        {
            //if(dieeffect!=null)
            //Instantiate(dieeffect, transform.position, transform.rotation);

            Destroy(gameObject);
        }
            
    }

    private void SetHealthBarUi()
    {
       // Debug.Log("function is accessed");
        float healthPercentage = CalculateHealthPercentage();
        healthbarSlider.value = healthPercentage;
        healthbarFillImage.color = Color.Lerp(zeroHealthColor, maxHealthColor, healthPercentage / 100);
    }

    private float CalculateHealthPercentage()
    {
        return ((float)currentHealth / (float)MaxHealth) * 100;
    }

}
