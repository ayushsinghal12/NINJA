using UnityEngine;

public class liftwall : MonoBehaviour
{
    public Rigidbody rb;
    public float dist=-1.2f;
    public float time=0.5f;
    void FixedUpdate()
    {
        GameObject[] ninjasLeft = GameObject.FindGameObjectsWithTag("enemy");
        GameObject[] targetsLeft = GameObject.FindGameObjectsWithTag("dartboard");
        if (ninjasLeft.Length==0 && targetsLeft.Length==0){
        rb.velocity=(Vector3.up*dist)/time;
        Invoke("destroy",time+0.2f);
        }
    }
    void destroy(){
        Destroy(gameObject);
    }
}
