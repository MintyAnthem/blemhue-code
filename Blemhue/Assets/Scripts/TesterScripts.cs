using UnityEngine;
using UnityEngine.InputSystem;

public class TesterScripts : MonoBehaviour
{
    public HungerSystem hungerSystem;
    public GameObject carrotBar;
    public GameObject meatBar;
    public GameObject oliveBar;

    public void OnTButton(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            hungerSystem.Add_Foodbar(carrotBar);
        }
    }

    public void OnYButton(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            hungerSystem.Add_Foodbar(meatBar);
        }
    }

    public void OnUButton(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            hungerSystem.Add_Foodbar(oliveBar);
        }
    }

}
