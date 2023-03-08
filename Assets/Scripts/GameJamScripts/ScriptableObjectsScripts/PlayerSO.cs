using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;


[CreateAssetMenu(fileName = "PlayerSO", menuName = "GameJam/PlayerSO")]
public class PlayerSO : ScriptableObject 

{
    
  [SerializeField]string playerName;
    [SerializeField]int playerHealth;
    [ShowAssetPreview(126,128)]
    [SerializeField]GameObject playerPrefab;
    [Space]
    [SerializeField]float playerSpeed;
    [SerializeField]int playerDamage;
    public string _playerName{
        get{return playerName;}
    }
    public int _playerHealth{
        get{return playerHealth;}
    }
    public GameObject _playerPrefab{
        get{return playerPrefab;}
    }
    public float _playerSpeed{
        get{return playerSpeed;}

    }
    public int _playerDamage{
        get{return playerDamage;}
    }
}
