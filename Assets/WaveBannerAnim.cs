using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class WaveBannerAnim : MonoBehaviour
{
    public float fadeTime;
    public void ShowObject()
    {
        StartCoroutine(DisableObject());
    }
    private IEnumerator DisableObject()
    {
        yield return new WaitForSeconds(fadeTime);
        gameObject.SetActive(false);
    }

}
