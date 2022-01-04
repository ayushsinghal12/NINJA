using UnityEngine;

public class enemyShrunikenInput : MonoBehaviour
{
    public GameObject throwableShruniken;
    public float firerate = 1;
    float nexttimetofire = 0;
    float dist;
    public Transform player;
    public Transform shrunikenLocation;
    public GameObject sound;
    void Update()
    {
        transform.LookAt(player);
        dist = Vector3.Distance(transform.position, player.position);
        if (Time.time > nexttimetofire && dist < 20 && Time.timeSinceLevelLoad > 1)
        {
            Instantiate(throwableShruniken, shrunikenLocation.position, shrunikenLocation.rotation);
            Instantiate(sound, transform.position, transform.rotation);
            nexttimetofire = Time.time + 1 / firerate;
        }
    }
}
