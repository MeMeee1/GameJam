
using UnityEngine;

[CreateAssetMenu(fileName = "LevelManager", menuName = "Managers/Level Manager")]
public class LevelManager : ScriptableObject
{
      [FancyHeader("  Level Manager  ", 1.5f, "blue", 5.5f, order = 0)]
        public LevelSO[] LevelSO;
         [SerializeField] int charIndex;
  
}
