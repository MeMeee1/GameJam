using UnityEngine;

public class FillSprite : MonoBehaviour
{
    [SerializeField]GameObject _object;
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - _object.transform.position);
    }
}
