using UnityEngine;

public class target : MonoBehaviour
{
    public ParticleSystem stream;
    public ParticleSystem spray;
    public int health=100;
    public GameObject bloodSound;
    public healthbar healthBar;
    void Start(){
        healthBar.setMaxHealth(health);
    }
    public void damage(int damage){
        Instantiate(bloodSound,transform.position,transform.rotation);
        health-=damage;
        healthBar.setHealth(health);
        if (health!=0){
            stream.Play();
        }
        if (health<1){
            spray.Play();
            Invoke("destroy",1);
        }
    }
    void destroy(){
        Destroy(gameObject);
    }
}
