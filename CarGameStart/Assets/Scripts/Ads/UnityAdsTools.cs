using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsTools : MonoBehaviour, IAdsShower, IUnityAdsListener
{
    private const string _gameId = "4450637";
    private const string _bannerPlacementId = "Banner_Android";
    private const string _rewardPlacementId = "Rewarded_Android";
    private const string _interstitialId = "Interstitial_Android";


    private void Start()
    {
        Advertisement.Initialize(_gameId, true);
    }
    public void ShowBaner()
    {
        Advertisement.Show(_bannerPlacementId);
    }

    public void ShowRewardVideo()
    {
        Advertisement.Show(_rewardPlacementId);
    }

    public void ShowInterstitialVideo()
    {
        Advertisement.Show(_interstitialId);
    }

    public void OnUnityAdsReady(string placementId)
    {
        
    }

    public void OnUnityAdsDidError(string message)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Skipped)
            Debug.Log("Skipped");
    }
}
