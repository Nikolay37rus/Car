using UnityEngine;

[CreateAssetMenu(fileName = "UpdateItemConfigDataSource", menuName = "UpdateItemConfigDataSource", order = 1)]
public class UpdateItemConfigDataSource : ScriptableObject
{
    [SerializeField]
    private UpgradeItemConfig[] _updateItemConfig;


    public UpgradeItemConfig[] _UpgradeItemConfig => _updateItemConfig;
}
