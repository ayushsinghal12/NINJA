using UnityEngine;

public class playerTarget : MonoBehaviour
{
    public int health=100;
    public ParticleSystem spray;
    public ParticleSystem stream;
    public GameObject bloodSound;
    public healthbar healthBar;
    public GameManager gamemanager;
    public cameraShake camerashake;
    void Start(){
        healthBar.setMaxHealth(health);
    }
    void Update(){
        if(Input.GetKey("r")){
            restart();
        }
    }
    public void damage(int damage){
        StartCoroutine(camerashake.shake(.2f,0.5f));
        Instantiate(bloodSound,transform.position,transform.rotation);
        health-=damage;
        if (health!=0){
            spray.Play();
        }
        health-=damage;
        healthBar.setHealth(health);
        if (health<=0){
            stream.Play();
            Invoke("restart",1);
        }
    }
    void restart(){
        gamemanager.restart();
    }
}
