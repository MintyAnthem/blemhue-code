using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerSystem : MonoBehaviour
{

    public List<GameObject> foodInStomach;
    public GameObject baseFoodBar;
    public FoodBar baseFoodBarScript;
    public Transform hungerBar;
    public float maxStomach = 800f;
    public float currentStomach = 0f;
    public bool isFull;
    public bool isEmpty;

    public void Start()
    {
        isEmpty = true;
    }

    public void Update()
    {
        if (!isFull)
        {
            if (foodInStomach.Count <= 0)
            {
                isEmpty = true;
            }
            else if (foodInStomach.Count >= 1)
            {
                isEmpty = false;
                //foodInStomach[foodInStomach.Count - 1].Deplete_FoodBar;
            }
        }

     }

    public void Add_Foodbar(FoodBarStatBlock foodBarStats)
    {
        if (!isFull)
        {
            currentStomach += foodBarStats.fullness;

            if(currentStomach < maxStomach)
            {
                baseFoodBarScript.foodBarStatBlock = foodBarStats;
                baseFoodBar.name = foodBarStats.name;
                GameObject foodBarClone = Instantiate(baseFoodBar, hungerBar);
                foodInStomach.Add(foodBarClone);
            }
            else if (currentStomach >= maxStomach)
            {
                float stomachDifference = currentStomach - maxStomach;
                currentStomach -= stomachDifference;
                foodBarStats.fullness -= stomachDifference;

                baseFoodBarScript.foodBarStatBlock = foodBarStats;
                baseFoodBar.name = foodBarStats.name;
                GameObject foodBarClone = Instantiate(baseFoodBar, hungerBar);
                foodInStomach.Add(foodBarClone);

                isFull = true;
            }


        }
        else if (isFull)
        {
            return;
        }

    }

    //public void Deplete_FoodBar(GameObject foodBar)
    //{
    //    foodBar.Image.fillAmount = playerStats.currentWait / playerStats.maxWait;
    //    playerStats.currentWait -= Time.deltaTime * playerStats.currentSpeed;
    //}
}
