using Profile;
using System.Collections.Generic;
using UnityEngine;

public class MainController : BaseController
{
    public MainController(Transform placeForUi, ProfilePlayer profilePlayer, List<ItemConfig> itemsConfig)
    {
        _profilePlayer = profilePlayer;
        _placeForUi = placeForUi;
        _itemsConfig = itemsConfig;

        OnChangeGameState(_profilePlayer.CurrentState.Value);
        profilePlayer.CurrentState.SubscribeOnChange(OnChangeGameState);
    }

    private MainMenuController _mainMenuController;
    private GameController _gameController;
    private InventoryController _inventoryController;

    private readonly Transform _placeForUi;
    private readonly ProfilePlayer _profilePlayer;
    private readonly List<ItemConfig> _itemsConfig;

    protected override void OnDispose()
    {
        AllClear();

        
        _profilePlayer.CurrentState.UnSubscriptionOnChange(OnChangeGameState);
        base.OnDispose();
    }

    private void OnChangeGameState(GameState state)
    {
        switch (state)
        {
            case GameState.Start:
                _mainMenuController = new MainMenuController(_placeForUi, _profilePlayer);
                _gameController?.Dispose();
                break;

            case GameState.Game:
                _gameController = new GameController(_profilePlayer);

                _inventoryController = new InventoryController(_itemsConfig);
                _inventoryController.ShowInventory();

                _mainMenuController?.Dispose();
                break;

            default:                
                AllClear();
                break;

                
        }
    }

    private void AllClear()
    {
        _mainMenuController?.Dispose();
        _gameController?.Dispose();
        _inventoryController?.Dispose();
    }
}
