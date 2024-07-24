using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public static HealthBar Instance;
	public Slider slider;
	public Gradient gradient;
	public Image fill;
	private int currentHealth;

	private void Awake()
    {
        Instance = this;	
    }
    public void SetMaxHealth(int health)
	{

		slider.maxValue = health;
		slider.value = health;
		currentHealth = health;
		fill.color = gradient.Evaluate(1f);
	}

    public void SetHealth(int health)
	{
		currentHealth += health;
		slider.value = currentHealth;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}
    public bool isOutOfHealth()
    {
        //return Score <= 0;

        bool isOutOfHealth;
        if (currentHealth <= 0)
        {
            isOutOfHealth = true;
        }
        else
        {
            isOutOfHealth = false;
        }
        return isOutOfHealth;
    }

}
