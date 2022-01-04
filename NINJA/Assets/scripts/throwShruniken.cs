using UnityEngine;

public class throwShruniken : MonoBehaviour
{
    public Rigidbody rb;
    Vector3 dir;
    public float speed = 100;
    public int damage = 10;
    float time;
    public float dist = 15;
    void Start()
    {
        GameObject a = GameObject.Find("Main Camera");
        dir = a.transform.forward;
        rb.AddForce(dir * speed, ForceMode.Impulse);
    }
    void Update()
    {
        time=dist/rb.velocity.magnitude;
        Invoke("destroy",time);
    }
    void OnTriggerEnter(Collider type)
    {
        target target = type.transform.GetComponent<target>();
        if (target != null)
        {
            target.damage(damage);
        }
        destroy();
    }
    void destroy()
    {
        Destroy(gameObject);
    }
}