using UnityEngine;

public class floatingShruniken : MonoBehaviour
{
    public shrunikenInput weaponinput;
    public GameObject sound;
    void OnTriggerEnter(Collider type){
        if (type.name=="player"){
            weaponinput.numberofshrunikens++;
            Instantiate(sound,transform.position,transform.rotation);
            Destroy(gameObject);
        }
    }
}
