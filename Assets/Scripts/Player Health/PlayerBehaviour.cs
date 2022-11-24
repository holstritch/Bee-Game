using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] HealthBar _energyBar;
    [SerializeField] HealthBar _happyBar;
    [SerializeField] HealthBar _hygeineBar;

    void Update()
    {
        // add damage or health
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DamageEnergy(10);
            Debug.Log(GameManager.gameManager._playerEnergy.Energy);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            DamageHappy(10);
            Debug.Log(GameManager.gameManager._playerHappy.Happy);
        }
    }
    // on click methods
    public void DrinkCoffeeForEnergy()
    {
        HealEnergy(10);
        Debug.Log(GameManager.gameManager._playerEnergy.Energy);
    }

    public void SqueezeForHappy()
    {
        HealHappy(10);
        Debug.Log(GameManager.gameManager._playerHappy.Happy);
    }
    public void ToiletForHygeine()
    {
        HealHygeine(10);
        Debug.Log(GameManager.gameManager._playerHygeine.Hygeine);
    }

    // energy
    private void DamageEnergy(int damage)
    {
        GameManager.gameManager._playerEnergy.DamageEnergy(damage);
        _energyBar.SetHealth(GameManager.gameManager._playerEnergy.Energy);
    }

    private void HealEnergy(int healing)
    {
        GameManager.gameManager._playerEnergy.HealEnergy(healing);
        _energyBar.SetHealth(GameManager.gameManager._playerEnergy.Energy);
    }

    // happy
    private void DamageHappy(int damage)
    {
        GameManager.gameManager._playerHappy.DamageHappy(damage);
        _happyBar.SetHealth(GameManager.gameManager._playerHappy.Happy);
    }
    private void HealHappy(int healing)
    {
        GameManager.gameManager._playerHappy.HealHappy(healing);
        _happyBar.SetHealth(GameManager.gameManager._playerHappy.Happy);
    }

    // hygeine
    private void DamageHygeine(int damage)
    {
        GameManager.gameManager._playerHygeine.DamageHygeine(damage);
        _hygeineBar.SetHealth(GameManager.gameManager._playerHygeine.Hygeine);
    }
    private void HealHygeine(int healing)
    {
        GameManager.gameManager._playerHygeine.HealHygeine(healing);
        _hygeineBar.SetHealth(GameManager.gameManager._playerHygeine.Hygeine);
    }
}
