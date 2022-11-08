using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileChanger : MonoBehaviour
{
    public Image profile;
    public List<Sprite> profileChoices;
    private int currentProfile = 0;

    public void ChangeImage()
    {
        currentProfile++;

        if(currentProfile >= profileChoices.Count)
        {
            currentProfile = 0;
        }

        profile.sprite = profileChoices[currentProfile];

    }

    
}
