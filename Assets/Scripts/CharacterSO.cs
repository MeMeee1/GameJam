using UnityEngine;
using NaughtyAttributes;
// Date updated: " + DateTime.Now.ToString("MM/dd/yyyy")
[CreateAssetMenu(fileName = "CharacterScriptableObject", menuName = "CharacterScriptableObject")]
public class CharacterSO: ScriptableObject
{
    [SerializeField] Sprite spriteImg;
    [SerializeField] string charName;
    [SerializeField] string charDescription;
    [SerializeField] int charSpeed;
    [SerializeField] float charStrength;
    [Space]
    [ShowAssetPreview(126,128)]
    [SerializeField] GameObject playerPrefab;
    public Sprite Img{
        get{return spriteImg;}
    }
    public string Name{
        get{return charName;}
    }
    public string Description{
        get{return charDescription;}
    }
    public int Speed{
        get{return charSpeed;}
    }
    public float Strength{
        get{return charStrength;}
    }
    


}