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
    public Transform lastFoodBar;
    public FoodBar lastFoodBarScript;
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
                lastFoodBar = hungerBar.GetChild(hungerBar.childCount - 1);
                lastFoodBarScript = lastFoodBar.GetComponent<FoodBar>();
                Deplete_Foodbar(lastFoodBarScript);
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

    public void Deplete_Foodbar(FoodBar foodBar)
    {
        foodBar.foodBarImage.fillAmount = foodBar.currentFullness / foodBar.foodBarStatBlock.fullness;
        foodBar.currentFullness -= Time.deltaTime * foodBar.foodBarStatBlock.quality;

        if (foodBar.currentFullness <= 0)
        {
            Destroy(lastFoodBar);
            lastFoodBar = hungerBar.GetChild(hungerBar.childCount - 1);
            lastFoodBarScript = lastFoodBar.GetComponent<FoodBar>();
        }
    }

    //public void Deplete_FoodBar(GameObject foodBar)
    //{
    //    foodBar.Image.fillAmount = playerStats.currentWait / playerStats.maxWait;
    //    playerStats.currentWait -= Time.deltaTime * playerStats.currentSpeed;
    //}
}
