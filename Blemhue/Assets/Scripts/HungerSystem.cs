using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerSystem : MonoBehaviour
{

    public List<GameObject> foodInStomach;
    public Transform hungerBar;
    public float maxStomach = 800f;
    public float currentStomach = 0f;
    public bool isFull;

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

    public void Add_Foodbar(GameObject foodBar)
    {
        if (!isFull)
        {
            //RectTransform foodBarRect = foodBar.GetComponent<RectTransform>();
            //currentStomach += foodBar.RectTransform.width;
            foodInStomach.Add(foodBar);
            Instantiate(foodBar, hungerBar);
        }
        else if (isFull)
        {
            return;
        }

    }

    public void Depleat_FoodBar(FoodBar foodBar)
    {
        return;
    }
}
