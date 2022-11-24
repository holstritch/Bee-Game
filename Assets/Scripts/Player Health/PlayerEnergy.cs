using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergy
{
    // fields 
    int _currentEnergy;
    int _currentMaxEnergy;

    // properties
    public int Energy
    {
        get
        {
            return _currentEnergy;
        }
        set
        {
            _currentEnergy = value;
        }
    }

    public int MaxHealth
    {
        get
        {
            return _currentMaxEnergy;
        }
        set
        {
            _currentMaxEnergy = value;
        }
    }

    // constructor 
    public PlayerEnergy(int energy, int maxHealth)
    {
        _currentEnergy = energy;
        _currentMaxEnergy = maxHealth;
    }

    // methods
    public void DamageEnergy(int damageAmount)
    {
        if (_currentEnergy > 0)
        {
            _currentEnergy -= damageAmount;
        }
    }

    public void HealEnergy(int healAmount)
    {
        if (_currentEnergy < _currentMaxEnergy)
        {
            _currentEnergy += healAmount;
        }
        // stops health being more than max
        if (_currentEnergy > _currentMaxEnergy)
        {
            _currentEnergy = _currentMaxEnergy;
        }
    }

}
