using UnityEngine;

[CreateAssetMenu(fileName = "AbilityItemConfig", menuName = "AbilityConfig")]

public class AbilityItemConfig :ScriptableObject
{
    [SerializeField]
    private ItemConfig _itemConfig;

    [SerializeField]
    private GameObject _view;

    [SerializeField]
    private AbilityType _abilitiType;

    [SerializeField]
    private float _value;

    public int Id => _itemConfig.Id;

    public float Value => _value;

    public AbilityType AbilityType => _abilitiType;

    public GameObject View => _view;

    public ItemConfig ItemConfig => _itemConfig;
}

public enum AbilityType
{
    None,
    Gun,
    Bomb
}
