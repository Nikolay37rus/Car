using Profile;
using UnityEngine;

public class Root : MonoBehaviour
{

    [SerializeField]
    private Transform _placeForUi;

    [SerializeField]
    private UnityAdsTools _unityAdsTools;

    private MainMenuController _mainController;

    private void Awake()
    {
        var profilePlayer = new ProfilePlayer(15f, _unityAdsTools);
        profilePlayer.CurrentState.Value = GameState.Start;
        _mainController = new MainMenuController(_placeForUi, profilePlayer);
    }

    protected void OcDestroy()
    {
        _mainController?.Dispose();
    }
}
