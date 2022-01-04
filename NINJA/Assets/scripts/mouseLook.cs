using UnityEngine;
using UnityEngine.EventSystems;

public class mouseLook : MonoBehaviour
{
    public float speed=200;
    public Transform player;
    float Xrotation=0;
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
        if (!IsMouseOverUI()){
            player.Rotate(Vector3.up * x);
        Xrotation-=y;
        Xrotation=Mathf.Clamp(Xrotation,-60,60);
        transform.localRotation=Quaternion.Euler(Xrotation,0,0);
        }
        
    }
    bool IsMouseOverUI(){
        return EventSystem.current.IsPointerOverGameObject();
    }
}
