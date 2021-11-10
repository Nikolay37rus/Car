using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class BaseController : IDisposable
{
    private List<BaseController> _baseControllers = new List<BaseController>();
    private List<GameObject> _gameObjects = new List<GameObject>();

    private bool _isDisposed;

    public void Dispose()
    {
        if (_isDisposed)
            return;

        _isDisposed = true;

        foreach (var baseController in _baseControllers)
            baseController?. Dispose();

        _baseControllers.Clear();

        foreach (var cachedGaameObject in _gameObjects)
            Object.Destroy(cachedGaameObject);

        _gameObjects.Clear();

        OnDispose();
    }

    protected void AddController(BaseController baseController)
    {
        _baseControllers.Add(baseController);
    }

    protected void AddGameObject(GameObject cachedGameObject)
    {
        _gameObjects.Add(cachedGameObject);
    }



    protected virtual void OnDispose()
    {

    }
}
