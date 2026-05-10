using UnityEngine;

[CreateAssetMenu(fileName = "FoodBar", menuName = "Scriptable Objects/FoodBar")]
public class FoodBar : ScriptableObject
{
    public string name;
    public Color color;

    public float fullness;
    public float quality;


}
