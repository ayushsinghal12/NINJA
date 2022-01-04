using UnityEngine;

public class enemyThrowShruniken : MonoBehaviour
{
    public Rigidbody rb;
    Vector3 dir;
    public float speed = 100;
    public int damage = 10;
    float time;
    public float dist = 15;
    void Start()
    {
        dir = transform.forward;
        rb.AddForce(dir * speed, ForceMode.Impulse);
    }
    void Update()
    {
        time=dist/rb.velocity.magnitude;
        Invoke("destroy",time);
    }
    void OnTriggerEnter(Collider type)
    {
        playerTarget target = type.transform.GetComponent<playerTarget>();
        if (target != null)
        {
            target.damage(damage);
        }
        if (type.name=="shield"){
            damage=5;
        }
        if (type.tag!="enemy" && type.name!="shield"){
        destroy();
        }
    }
    void destroy()
    {
        Destroy(gameObject);
    }
}