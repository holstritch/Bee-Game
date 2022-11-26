using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // singleton class

    // property instead of field to add private protection level
    public static GameManager gameManager { get; private set; }

    // instantiate 
    public PlayerEnergy _playerEnergy = new PlayerEnergy(100, 100);
    public PlayerHappy _playerHappy = new PlayerHappy(100, 100);
    public PlayerHygiene _playerHygiene = new PlayerHygiene(100, 100);

    void Awake()
    {
        // deletes if another GameManager is accidentally made
        if (gameManager != null && gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }

}
