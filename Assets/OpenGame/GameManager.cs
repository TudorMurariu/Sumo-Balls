using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    void Start()
    {
        
    }

    public void StartGame()
    {
        Debug.Log("Enter Game");
        SceneManager.LoadScene("Game");
    }

    public void Options()
    {
        Debug.Log("Options");
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    
    public void ExitOptions()
    {
        Debug.Log("Exit Options");
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("Exit game");
        Application.Quit();
    }
}
