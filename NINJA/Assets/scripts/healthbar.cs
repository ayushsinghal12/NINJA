using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1);
    }
    public void setHealth(int health)
    {
        slider.value = health;
        fill.color=gradient.Evaluate(slider.normalizedValue);
    }
}
