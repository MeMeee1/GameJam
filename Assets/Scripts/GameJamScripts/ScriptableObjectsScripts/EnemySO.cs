using UnityEngine;
using NaughtyAttributes;
// Date updated: " + DateTime.Now.ToString("MM/dd/yyyy")
[CreateAssetMenu(menuName = "Managers/EnemySO")]
public class EnemySO : ScriptableObject
{
    [SerializeField]string enemyName;
    [SerializeField]int enemyHealth;
    [ShowAssetPreview(126,128)]
    [SerializeField]GameObject enemyPrefab;
    [Space]
    [SerializeField]float enemySpeed;
    [SerializeField]int enemyDamage;
    public string _enemyName{
        get{return enemyName;}
    }
    public int _enemyHealth{
        get{return enemyHealth;}
    }
    public GameObject _enemyPrefab{
        get{return enemyPrefab;}
    }
    public float _enemySpeed{
        get{return enemySpeed;}

    }
    public int _enemyDamage{
        get{return enemyDamage;}
    }

}