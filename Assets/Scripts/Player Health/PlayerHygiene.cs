using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHygiene
{
    // fields 
    int _currentHygiene;
    int _currentMaxHygiene;

    // properties
    public int Hygiene
    {
        get
        {
            return _currentHygiene;
        }
        set
        {
            _currentHygiene = value;
        }
    }

    public int MaxHygiene
    {
        get
        {
            return _currentMaxHygiene;
        }
        set
        {
            _currentMaxHygiene = value;
        }
    }

    // constructor 
    public PlayerHygiene(int hygiene, int maxHygiene)
    {
        _currentHygiene = hygiene;
        _currentMaxHygiene = maxHygiene;
    }

    // methods
    public void DamageHygiene(int damageAmount)
    {
        if (_currentHygiene > 0)
        {
            _currentHygiene -= damageAmount;
        }
    }

    public void HealHygiene(int healAmount)
    {
        if (_currentHygiene < _currentMaxHygiene)
        {
            _currentHygiene += healAmount;
        }
        // stops health being more than max
        if (_currentHygiene > _currentMaxHygiene)
        {
            _currentHygiene = _currentMaxHygiene;
        }
    }
}
