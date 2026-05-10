using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerSystem : MonoBehaviour
{

    public List<FoodBar> foodInStomach;
    public Transform hungerBar;
    public GameObject baseBar;

    //public void Update()
    //{
    //    if (foodInStomach.Count == 0)
    //    {
    //        return;
    //    }
    //    else
    //    {
    //        //for (int i = 0; i < foodInStomach.Count; i++)
    //        //{
    //        //    // Access item by index
    //        //    Debug.Log("Enemy name: " + enemies[i].name);
    //        //}
    //        return;
    //    }
    //}

    public void Add_FoodBar(FoodBar foodBar)
    {
        foodInStomach.Add(foodBar);

        GameObject newBar = baseBar;
        Instantiate(newBar, hungerBar);
        newBar.name = foodBar.name;
        Image newBarImage = newBar.GetComponent<Image>();
        newBarImage.color = foodBar.color;
        RectTransform newBarRect = newBar.GetComponent<RectTransform>();
        newBarRect.sizeDelta = new Vector2(foodBar.fullness, 60);
    }

    public void Depleat_FoodBar(FoodBar foodBar)
    {
        return;
    }
}
