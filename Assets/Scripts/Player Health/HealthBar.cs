using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    Slider _slider;

    private void Start()
    {
        _slider = GetComponent<Slider>();
    }
    public void SetMaxHealth(int maxHealth)
    {
        _slider.maxValue = maxHealth;
        _slider.value = maxHealth;
    }

    public void SetHealth(int health)
    {
        _slider.value = health;
    }
}
