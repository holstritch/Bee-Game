using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProfileChanger : MonoBehaviour
{
    public Image profile;
    public List<Sprite> profileChoices;
    public int currentProfile = 0;
    public GameObject winText;
    public Button matchButton;
     //public int randomProfile = 0;

    public void ChangeImageUp() // Go to next profile image
    {
        currentProfile++;

        if(currentProfile >= profileChoices.Count) // Reset to first image if you reach end of list
        {
            currentProfile = 0;
        }

        profile.sprite = profileChoices[currentProfile];

    }

    public void ChangeImageDown() // Go to previous profile image
    {
        currentProfile--;

        if(currentProfile < 0) // Reset to final image if you reach start of list
        {
            currentProfile = profileChoices.Count - 1; 
        }

        profile.sprite = profileChoices[currentProfile];

    }
    
    public void RemoveCurrentProfile()
    {
        // Remove this profile from the list
        profileChoices.RemoveAt(currentProfile);

        // Move automatically to first profile after removing
        currentProfile = 0;
        profile.sprite = profileChoices[currentProfile];
    }

    public void WinChecker()
    {
        if (profileChoices.Count == 1)
        {
            // Show text saying you matched them all
            winText.SetActive(true);

            // Stop player clicking match button again
            matchButton.interactable = false;

        }
    }

    /*
    public void ChangeToRandomProfile()
    {
        // Get a random profile
        randomProfile = 1 + (randomProfile + Random.Range(0, profileChoices.Count));

        // If the random profile number is bigger than profiles available, reset
        if (randomProfile > profileChoices.Count) 
        {
            randomProfile -= profileChoices.Count;
        }
        
        // Change the profile sprite
        profile.sprite = profileChoices[randomProfile];
    }

    */

}
