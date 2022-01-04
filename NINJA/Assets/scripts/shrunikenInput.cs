using UnityEngine;

public class shrunikenInput : MonoBehaviour
{
    public float numberofshrunikens = 0;
    public GameObject throwableShruniken;
    public float firerate = 2;
    float nexttimetofire = 0;
    public GameObject sound;
    void Update()
    {
        if (Input.GetButton("Fire1") && numberofshrunikens > 0 && Time.time > nexttimetofire)
        {
            Instantiate(throwableShruniken, transform.position, transform.rotation);
            Instantiate(sound, transform.position, transform.rotation);
            nexttimetofire = Time.time + 1 / firerate;
            numberofshrunikens--;
        }
    }
    public void shoot()
    {
        if (numberofshrunikens > 0 && Time.time > nexttimetofire)
        {
            Instantiate(throwableShruniken, transform.position, transform.rotation);
            Instantiate(sound, transform.position, transform.rotation);
            nexttimetofire = Time.time + 1 / firerate;
            numberofshrunikens--;
        }

    }
}
