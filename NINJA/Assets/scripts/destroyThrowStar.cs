using UnityEngine;

public class destroyThrowStar : MonoBehaviour
{
    void Update()
    {
        Invoke("destroy",0.4f);
    }
    void destroy(){
        Destroy(gameObject);
    }
}
