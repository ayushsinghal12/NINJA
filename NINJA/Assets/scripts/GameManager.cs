using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void nextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
