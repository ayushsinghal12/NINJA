using UnityEngine;

public class destroyBloodSound : MonoBehaviour
{
    void Update()
    {
        Invoke("destroy",1);
    }
    void destroy(){
        Destroy(gameObject);
    }
}
