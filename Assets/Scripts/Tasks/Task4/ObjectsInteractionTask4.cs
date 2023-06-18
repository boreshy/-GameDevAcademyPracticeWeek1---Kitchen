using System;
using UnityEngine;
using UnityEngine.Serialization;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] private GameObject _waffle;
    [SerializeField] private Transform _waffleSpawnPoint;

    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 

    private void Awake()
    {
        GameObject kitchen = GameObject.Find("Kitchen");
        Transform toasterTransform = kitchen.transform.Find("Toaster");
        Toaster toaster = toasterTransform.GetComponent<Toaster>();


        toaster.TimerIsUp += OnTimerIsUp;
    }

    private void OnTimerIsUp()
    {
        GameObject waffle = Instantiate(_waffle, _waffleSpawnPoint.position, _waffleSpawnPoint.rotation);
    }
}