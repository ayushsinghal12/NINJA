using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene("level1");
    }
}
