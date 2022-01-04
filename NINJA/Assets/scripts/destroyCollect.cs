using UnityEngine;

public class destroyCollect : MonoBehaviour
{
    void Update()
    {
        Invoke("destroy",0.65f);
    }
    void destroy(){
        Destroy(gameObject);
    }
}
