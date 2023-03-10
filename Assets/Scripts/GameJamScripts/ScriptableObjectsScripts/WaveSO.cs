using UnityEngine;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
// Date updated: " + DateTime.Now.ToString("MM/dd/yyyy")
[CreateAssetMenu(fileName = "WaveSO", menuName = "WaveSO")]
public class WaveSO : ScriptableObject
{
    //Add your code
    [SerializeField]EnemySO[] _enemytoSpawn;
    [SerializeField]float timer;
    [SerializeField]GameEvent OnSpawnObjects;
    public void UpdateTimer()
    {if(timer >=0)
        {
            timer-=Time.deltaTime;
            if(timer <= 0)
            {
                OnSpawnObjects.Raise();
            }
        }
    }
    public EnemySO[] enemySpawn{
        get{return _enemytoSpawn;}
    }
    public float _ntimer{
        get{return timer;}
    }

    
    
    
    
}