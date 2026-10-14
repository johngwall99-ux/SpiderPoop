using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject gameOverScreen;
    FartHandler fartHandler;

    private void Awake()
    {
        fartHandler = GameObject.FindGameObjectWithTag("Audio").GetComponent<FartHandler>();
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverScreen.SetActive(false);
        Time.timeScale = 1f;
    }

    public void TriggerGameOver()
    {
        gameOverScreen.SetActive(true);
        fartHandler.PlayRandomFart(fartHandler.splat);
        fartHandler.PlayRandomFart(fartHandler.scream);
        Time.timeScale = 0f;
        
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void StartMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
