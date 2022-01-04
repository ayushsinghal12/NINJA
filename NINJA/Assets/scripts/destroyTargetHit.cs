using UnityEngine;

public class destroyTargetHit : MonoBehaviour
{
    void Update()
    {
        Invoke("destroy", 0.4f);
    }
    void destroy()
    {
        Destroy(gameObject);
    }
}
