using UnityEngine;
#if UNITY_ADS
using UnityEngine.Advertisements;
#endif

public class UnityAdsExample : MonoBehaviour
{
    void Start()
    {
        Advertisement.Initialize("1344541", true);

        StartCoroutine(ShowAdWhenReady());
    }

    System.Collections.IEnumerator ShowAdWhenReady()
    {
        while (!Advertisement.IsReady())
            yield return null;

        Advertisement.Show();
    }


}