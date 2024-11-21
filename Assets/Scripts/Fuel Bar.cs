using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{
    public Slider fuel;
    ScriptObject sc;
    public void SetMaxFuel(int Fuel)
    {
        fuel.maxValue = Fuel;
        fuel.value = Fuel;
    }
    public void SetFuel()
    {
        fuel.value = sc.currentFuel;
    }
}
