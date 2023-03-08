using UnityEngine;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
// Date updated: " + DateTime.Now.ToString("MM/dd/yyyy")
[CreateAssetMenu(fileName = "Managers/EnemyManager", menuName = "EnemyManager")]
public class EnemyManager : ScriptableObject
{
    [FancyHeader("  Enemy Manager  ", 1.5f, "blue", 5.5f, order = 0)]
    [SerializeField] List<EnemySO> charObjects;
    
    [SerializeField] int charIndex;
    
    [SerializeField]CharacterUnityEvent _mcharacterevent;
    public void UpdateCharacter()
    {
        for (int i = 0; i < charObjects.Count; i++)
        {
            //_mcharacterevent.Raise(charObjects[i]);
        }
    }
}