using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    
    [SerializeField] private Transform _lampSpawnPoint;
    [SerializeField] private GameObject _lamp;

    private Lamp[] _lamps;
    private void Awake()
    {
        GameObject lamp = Instantiate(_lamp, _lampSpawnPoint.position, _lampSpawnPoint.rotation);
        _lamps = lamp.GetComponentsInChildren<Lamp>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (Lamp lamp in _lamps)
            {
                lamp.Interact();
            }
        }
    }
}