using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Void Event", menuName = "Game Events/CharacterSOEvent")]

public class CharacterUnityEvent :BaseGameEvent<CharacterSO>
{
    public CharacterSO testProperty;
}
