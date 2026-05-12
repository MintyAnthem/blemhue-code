using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    public SpriteRenderer collectableSpriteRenderer;
    public GameObject collectableObject;
    //public ItemStats itemStats;
    public Sprite itemStatsSprite;
    public FoodBarStatBlock barStats;
    public GameObject hungerSystemObj;
    public HungerSystem hungerSystem;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        hungerSystemObj = GameObject.Find("HungerSystem");
        hungerSystem = hungerSystemObj.GetComponent<HungerSystem>();
        collectableSpriteRenderer.sprite = itemStatsSprite;
    }

    public void OnTriggerEnter2D(Collider2D trigger)
    {
        hungerSystem.Add_Foodbar(barStats);
        Destroy(collectableObject);
    }
}
