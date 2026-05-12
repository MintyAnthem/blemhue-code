using UnityEngine;

[CreateAssetMenu(fileName = "FoodBarStatBlock", menuName = "Scriptable Objects/FoodBarStatBlock")]
public class FoodBarStatBlock : ScriptableObject
{
    public string name;
    public Color color;

    public float fullness;
    public float quality;


}
