using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;
public class Ads : MonoBehaviour, IUnityAdsListener
{
    [SerializeField] string androidID = "4405245";

    [SerializeField] string doubleMoneyVideoPlacement = "Rewarded_Android";
    [SerializeField] string skippableVideoPlacement = "Interstitial_Android";



    // Start is called before the first frame update
    void Start()
    {
        Advertisement.AddListener(this);



        Advertisement.Initialize(androidID);
    }


    public void ShowDoubleMoneyAd()
    {
        Advertisement.Show(doubleMoneyVideoPlacement);

    }


    public void ShowSkippableAd()
    {
        Advertisement.Show(skippableVideoPlacement);
    }


    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            if (placementId == doubleMoneyVideoPlacement)
            {
                IdleManager.instance.CollectBonusMoney();
            }
        }
    }


    public void OnUnityAdsDidError(string message)
    {
       
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        
    }

    public void OnUnityAdsReady(string placementId)
    {
        
    }


    public void LoadHome()
    {
        SceneManager.LoadScene(0);
    }
}
