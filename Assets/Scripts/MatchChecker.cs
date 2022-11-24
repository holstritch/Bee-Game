using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MatchChecker : MonoBehaviour
{
    public ProfileChanger profileChanger1;
    public ProfileChanger profileChanger2;
    public Image profile1;
    public Image profile2;
    public int honey = 0;
    public TextMeshProUGUI honeyText;

    
    public void CheckForMatch() 
    {
        // Check for match based on sprite names

        if (profile1.sprite.name == ("A1") && profile2.sprite.name == ("B1"))
        {
            Debug.Log("Match!");
            OnMatch();
        }

        else if (profile1.sprite.name == ("A2") && profile2.sprite.name == ("B2"))
        {
            Debug.Log("Match!");
            OnMatch();
        }

        else if (profile1.sprite.name == ("A3") && profile2.sprite.name == ("B3"))
        {
            Debug.Log("Match!");
            OnMatch();
        }

        else if (profile1.sprite.name == ("A4") && profile2.sprite.name == ("B4"))
        {
            Debug.Log("Match!");
            OnMatch();
        }

        else if (profile1.sprite.name == ("A5") && profile2.sprite.name == ("B5"))
        {
            Debug.Log("Match!");
            OnMatch();
        }

        else
        {
            Debug.Log("These two aren't a match.");
        }

        // Check if these are the last two profiles to match
        profileChanger1.WinChecker(); 
        
    }

    private void OnMatch() 
    {
        // Increase honey
        honey = honey + 100;

        // Remove these bees from the list
        profileChanger1.RemoveCurrentProfile();
        profileChanger2.RemoveCurrentProfile();

        // Update UI text
        honeyText.text = "Honey: " + honey;
    }
}
