using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelSO", menuName = "GameJam/LevelSO")]
public class LevelSO : ScriptableObject 
{
    [SerializeField]EnemySO[] numberOfHumans;
    [SerializeField]EnemySO[] numberOfTankers;
    [SerializeField]EnemySO[] numberOfSoldiers;

    public EnemySO[] _numberOfHumans{
        get{return numberOfHumans;}
    }
     public EnemySO[] _numberOfTankers{
        get{return numberOfTankers;}
    }
     public EnemySO[] _numberOfSoldiers{
        get{return numberOfSoldiers;}
    }
}
