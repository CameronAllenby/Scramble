using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{
    public Slider fuel;
    ScriptObject sc;
    public void SetMaxFuel()
    {
        fuel.maxValue = sc.maxFuel;
        
    }
    public void SetFuel()
    {
        fuel.value = sc.currentFuel;
    }
}
