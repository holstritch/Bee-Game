using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // singleton class

    // property instead of field to add private protection level
    public static GameManager gameManager { get; private set; }

    // instantiate 
    public PlayerHealth _playerHealth = new PlayerHealth(100, 100);
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
