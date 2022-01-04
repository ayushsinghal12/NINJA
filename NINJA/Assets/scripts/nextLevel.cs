using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    public GameManager gamemanager;
    void OnTriggerEnter(){
        gamemanager.nextLevel();
    }
}
