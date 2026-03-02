using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private string _scene;
    public void InitGame()
    {
        SceneManager.LoadScene(_scene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
