using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    private void Start()
    {
        // Найти объект Kitchen на сцене
        GameObject kitchen = GameObject.Find("Kitchen");

        // Найти полки внутри объекта Kitchen
        Shelf[] shelves = kitchen.GetComponentsInChildren<Shelf>();

        // Подписаться на событие ItemSpawned для каждой полки
        foreach (Shelf shelf in shelves)
        {
            shelf.ItemSpawned += OnItemSpawned;
        }
    }

    private void OnItemSpawned()
    {
        // Проверить количество предметов на полке
        // Если больше трех, вызвать метод Fall у полки
        Shelf[] shelves = FindObjectsOfType<Shelf>();
        foreach (Shelf shelf in shelves)
        {
            if (shelf.ItemsCount > 3)
            {
                shelf.Fall();
            }
        }
    }
}
