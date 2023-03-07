using NaughtyAttributes;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "Managers/GameState Manager")]
#if UNITY_EDITOR
[FilePath("Scriptable Objects/Managers/GameStateManager.asset", FilePathAttribute.Location.PreferencesFolder)]
#endif
public class GameStateManager : SingletonScriptableObject<GameStateManager>
{
    [SerializeField] CharacterManagerSO m_characterManager;
    public static CharacterManagerSO CharacterManagerSO{
        get{return Instance.m_characterManager;}
    }
}