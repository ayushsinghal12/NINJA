using UnityEngine;
using UnityEngine.UI;

public class shrunikenText : MonoBehaviour
{
    public shrunikenInput shrunikeninput;
    public Text shrunikentext;
    void Update()
    {
        shrunikentext.text=(shrunikeninput.numberofshrunikens).ToString();
    }
}
