using UnityEngine;
using UnityEngine.UI;

public class targetText : MonoBehaviour
{
    public Text targettext;
    void Update()
    {
        GameObject[] targetsLeft = GameObject.FindGameObjectsWithTag("dartboard");
        targettext.text=(targetsLeft.Length).ToString();
    }
}
