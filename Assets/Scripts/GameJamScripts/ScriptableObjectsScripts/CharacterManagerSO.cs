using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NaughtyAttributes;
[CreateAssetMenu(menuName = "Managers/Character Manager")]
public class CharacterManagerSO : ScriptableObject
{
    [FancyHeader("  Character Manager  ", 1.5f, "blue", 5.5f, order = 0)]
    [SerializeField] List<CharacterSO> charObjects;
    
    [SerializeField] int charIndex;
    
    [SerializeField]CharacterUnityEvent _mcharacterevent;
    public void UpdateCharacter()
    {
        for (int i = 0; i < charObjects.Count; i++)
        {
            _mcharacterevent.Raise(charObjects[i]);
        }
    }

    // [SerializeField]private Button nextButton;
    // [SerializeField]private Button prevButton;


    
    // public void NextCharacter()
    // {
    //     if (charIndex < charObjects.Count - 1)
    //     {
    //         charIndex++;
    //         CheckButtonAvailability();
            
    //     }
    // }

    // public void PreviousCharacter()
    // {
    //     if (charIndex > 0)
    //     {
    //         charIndex--;
    //         CheckButtonAvailability();
            
    //     }
    // }


    // public void SelectCharacter()
    // {
    //     PlayerPrefs.SetInt("playerIndex", charIndex);
    // }

    // private void ShowSO()
    // {
    //     charDescription.text = "<b>Description</b>\n"+ charObjects[charIndex].Description;
    //     charImg.sprite = charObjects[charIndex].Img;
    //     charName.text =charObjects[charIndex].Name;
    //     charSpeed.text = "<b>Speed</b>: "+charObjects[charIndex].Speed.ToString();
    //     charStrength.text = "<b>Strength</b>:"+charObjects[charIndex].Strength.ToString();
    // }

    // public void CheckButtonAvailability()
    // {
    //     if (charIndex == 0)
    //     {
    //         prevButton.interactable = false;
            
    //     }
    //     else if (charIndex == charObjects.Count - 1)
    //     {
    //         nextButton.interactable = false;
    //         }
    //     else
    //     {
    //         prevButton.interactable = true;
    //         nextButton.interactable = true;
    //     }
    // }
}
