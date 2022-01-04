using UnityEngine;

public class dartboard : MonoBehaviour
{
    public GameObject sound;
    void OnTriggerEnter(Collider type){
        if (type.tag=="shruniken"){
            Instantiate(sound,transform.position,transform.rotation);
            Destroy(gameObject);
        }
    }
}
