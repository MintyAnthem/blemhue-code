using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerSystem : MonoBehaviour
{

    public List<FoodBar> foodInStomach;
    public Transform hungerBar;

    public void Update()
    {
        if (foodInStomach.Count == 0)
        {
            return;
        }
        else
        {
            //for (int i = 0; i < foodInStomach.Count; i++)
            //{
            //    // Access item by index
            //    Debug.Log("Enemy name: " + enemies[i].name);
            //}
            return;
        }
    }

    public void Add_FoodBar(FoodBar foodBar)
    {
        foodInStomach.Add(foodBar);

        GameObject newBar = new GameObject(foodBar.name, typeof(RectTransform));
        newBar.AddComponent<Image>();
        Image newBarImage = newBar.GetComponent<Image>();
        RectTransform newBarRectTransform = newBar.GetComponent<RectTransform>();
        newBarRectTransform.SetParent(hungerBar);
        newBarRectTransform.sizeDelta = new Vector2(foodBar.fullness, 60);
        newBarImage.color = foodBar.color;
        Instantiate(newBar);
    }

    public void Depleat_FoodBar(FoodBar foodBar)
    {
        return;
    }
}
