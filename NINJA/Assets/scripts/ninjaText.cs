using UnityEngine;
using UnityEngine.UI;

public class ninjaText : MonoBehaviour
{
    public Text ninjatext;
    void Update()
    {
        GameObject[] ninjasLeft = GameObject.FindGameObjectsWithTag("enemy");
        ninjatext.text=(ninjasLeft.Length).ToString();
    }
}
