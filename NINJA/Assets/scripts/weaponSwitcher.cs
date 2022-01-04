using UnityEngine;
using UnityEngine.UI;
public class weaponSwitcher : MonoBehaviour
{
    public GameObject[] weapons;
    float selectedweapon = 0;
    public Text weaponDisplay;
    void Update()
    {
        selectWeapon();
    }
    void selectWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weapon1();

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weapon2();
        }
        if (selectedweapon == 0)
        {
            weaponDisplay.text = "SHURIKEN";
        }
        if (selectedweapon == 1)
        {
            weaponDisplay.text = "SHIELD";
        }
        for (int i = 0; i < weapons.Length; i++)
        {
            if (i == selectedweapon)
            {
                weapons[i].SetActive(true);
            }
            else
            {
                weapons[i].SetActive(false);
            }
        }
    }
    public void weapon1(){
        selectedweapon = 0;
    }
    public void weapon2(){
        selectedweapon = 1;
    }
}
