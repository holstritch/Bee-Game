using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MatchChecker : MonoBehaviour
{
    public ProfileChanger profileChanger1;
    public ProfileChanger profileChanger2;
    public int bee1;
    public int bee2;
    public int honey = 0;
    public TextMeshProUGUI honeyText;

    
    public void CheckForMatch() 
    {
        // Check which bee is in each slot
        bee1 = profileChanger1.randomProfile;  
        bee2 = profileChanger2.randomProfile; 
        
        // Check if the bees are a match or not
        if(bee1 == bee2)
        {
            // Increase honey
            honey = honey + 100;
            UpdateUI();

            // Remove these bees from the list
            profileChanger1.RemoveCurrentProfile();
            profileChanger2.RemoveCurrentProfile();

            // Add cash sound effect
        }

        if(bee1 != bee2)
        {
            Debug.Log("These two aren't a match.");
            
            // Add incorrect sound effect
        }

        // Check if these are the last two profiles to match
        profileChanger1.WinChecker(); 
        
    }


    private void UpdateUI() 
    {
      honeyText.text = "Honey: " + honey;
    }
}
