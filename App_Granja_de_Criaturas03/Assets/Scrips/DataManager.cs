using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private List<Item> items = new List<Item>();
    [SerializeField] private GameObject buttonContainer;
    [SerializeField] private ItemBottonManager itemBottonManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnItemsMenu += CreateButton;
       
    }

    private void CreateButton()
    {
      foreach(var item in items)
        {
            ItemBottonManager itemBotton;
            itemBotton = Instantiate(itemBottonManager, buttonContainer.transform);
            itemBotton.ItemName = item.ItemName;
            itemBotton.ItemDescription = item.ItemDescription;
            itemBotton.ItemImage = item.ItemImage;
            itemBotton.Item3DModel = item.Item3DModel;
            itemBotton.name = item.ItemName;

        }

        GameManager.instance.OnItemsMenu -= CreateButton;
    }
}
