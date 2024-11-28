using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{
    public Slider fuel;
  
    public void SetMaxFuel(int fuelA)
    {
        fuel.maxValue = fuelA;
        fuel.value = fuelA;
        
    }
    public void SetFuel(int fuelA)
    {
        fuel.value = fuelA;
    }
}
