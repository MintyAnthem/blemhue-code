using UnityEngine;
using UnityEngine.UI;

public class FoodBar : MonoBehaviour
{
    
    public FoodBarStatBlock foodBarStatBlock;
    public RectTransform foodBarRect;
    public Image foodBarImage;
    public float currentFullness;

    public void Awake()
    {
        foodBarImage.color = foodBarStatBlock.color;
        foodBarRect.sizeDelta = new Vector2(foodBarStatBlock.fullness, 60);
        currentFullness = foodBarStatBlock.fullness;
    }




}
