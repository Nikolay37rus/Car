using UnityEngine;
using Object = UnityEngine.Object;


public class CarController : BaseController
{
    private readonly ResourcePath _vievPath = new ResourcePath { PathResource = "Prefabs/Car" };
    private readonly CarView _carView;

    public CarController()
    {
        _carView = LoadView();
    }

    private CarView LoadView()
    {
        var objView = Object.Instantiate(ResourceLoader.LoadPrefab(_vievPath));
        AddGameObject(objView);

        return objView.GetComponent<CarView>();
    }

    public GameObject GetViewObject()
    {
        return _carView.gameObject;
    }
}
