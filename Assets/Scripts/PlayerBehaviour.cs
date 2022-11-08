using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] HealthBar _healthBar;

    void Start()
    {
        
    }

    void Update()
    {
        // add damage or health
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerTakeDamage(20);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerHeal(10);
            Debug.Log(GameManager.gameManager._playerHealth.Health);
        }
    }

    private void PlayerTakeDamage(int damage)
    {
        GameManager.gameManager._playerHealth.DamageHealth(damage);
        _healthBar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }

    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealHealth(healing);
        _healthBar.SetHealth(GameManager.gameManager._playerHealth.Health);
    }
}
