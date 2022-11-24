using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHygeine
{
    // fields 
    int _currentHygeine;
    int _currentMaxHygeine;

    // properties
    public int Hygeine
    {
        get
        {
            return _currentHygeine;
        }
        set
        {
            _currentHygeine = value;
        }
    }

    public int MaxHygeine
    {
        get
        {
            return _currentMaxHygeine;
        }
        set
        {
            _currentMaxHygeine = value;
        }
    }

    // constructor 
    public PlayerHygeine(int hygeine, int maxHygeine)
    {
        _currentHygeine = hygeine;
        _currentMaxHygeine = maxHygeine;
    }

    // methods
    public void DamageHygeine(int damageAmount)
    {
        if (_currentHygeine > 0)
        {
            _currentHygeine -= damageAmount;
        }
    }

    public void HealHygeine(int healAmount)
    {
        if (_currentHygeine < _currentMaxHygeine)
        {
            _currentHygeine += healAmount;
        }
        // stops health being more than max
        if (_currentHygeine > _currentMaxHygeine)
        {
            _currentHygeine = _currentMaxHygeine;
        }
    }
}
