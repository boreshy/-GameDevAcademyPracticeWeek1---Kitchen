using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField] private GameObject _lamp;
    [SerializeField] private Transform _lampSpawnPoint;
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps) 

    private void Awake()
    {
        GameObject lamp = Instantiate(_lamp, _lampSpawnPoint.position, _lampSpawnPoint.rotation);

        GameObject kitchen = GameObject.Find("Kitchen");

        if (kitchen != null)
        {
            lamp.transform.parent = kitchen.transform;
        }
    }
}