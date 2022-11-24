using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHappy
{
    // fields 
    int _currentHappy;
    int _currentMaxHappy;

    // properties
    public int Happy
    {
        get
        {
            return _currentHappy;
        }
        set
        {
            _currentHappy = value;
        }
    }

    public int MaxHappy
    {
        get
        {
            return _currentMaxHappy;
        }
        set
        {
            _currentMaxHappy = value;
        }
    }

    // constructor 
    public PlayerHappy(int happy, int maxHappy)
    {
        _currentHappy = happy;
        _currentMaxHappy = maxHappy;
    }

    // methods
    public void DamageHappy(int damageAmount)
    {
        if (_currentHappy > 0)
        {
            _currentHappy -= damageAmount;
        }
    }

    public void HealHappy(int healAmount)
    {
        if (_currentHappy < _currentMaxHappy)
        {
            _currentHappy += healAmount;
        }
        // stops health being more than max
        if (_currentHappy > _currentMaxHappy)
        {
            _currentHappy = _currentMaxHappy;
        }
    }
}
