using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    [SerializeField]
    private Button _buttonStart;

    public void Init(UnityAction statGame)
    {
        _buttonStart.onClick.AddListener(statGame);
    }

    private void OnDestroy()
    {
        _buttonStart.onClick.RemoveAllListeners();
    }
}
