using System;
using UnityEngine;

public class ObjectsInteractionTask1 : MonoBehaviour
{
    // TODO: Получите доступ к объекту со скриптом Refrigerator при помощи атрибута [SerializeField]
    [SerializeField] private GameObject _refrigerator;

    private Refrigerator _refrigeratorComponent;
    // TODO: При нажатии на кнопку 1 на клавиатуре вызывайте у него метод Interact


    private void Start()
    {
        _refrigeratorComponent = _refrigerator.GetComponent<Refrigerator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            _refrigeratorComponent.Interact();
        }
    }
}