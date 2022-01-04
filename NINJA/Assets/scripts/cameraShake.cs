using System.Collections;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
   public  IEnumerator shake(float duration, float magnitude){
        Vector3 ogposition=transform.localPosition;
        float elapsed=0;
        while(elapsed<duration){
            float x= Random.Range(-1,1) * magnitude;
            float y= Random.Range(-1,1) * magnitude;
            transform.localPosition=new Vector3(x,y,ogposition.z);
            elapsed+=Time.deltaTime;
            yield return null;
        }
        transform.localPosition=ogposition;
    }
}
