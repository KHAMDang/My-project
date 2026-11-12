using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager _cGM;

    public bool bPaused = false;
    public bool bGameOver = false;

    public void Awake()
    {
        _cGM = this;
    }

    public void StartGame()
    {
        Debug.Log("GameManager start");
        bGameOver = false;
        bPaused = false;
        Time.timeScale = 1f;
    }

    public void StopGame()
    {
        Debug.Log("Game Stop");
        bGameOver = true;
        Time.timeScale = 0f;
    }

    public void PauseGame()
    {
        if(bGameOver) return;

        if(Input.GetKey(KeyCode.Q))
        {
            bPaused = !bPaused;

            if(bPaused)
            {
                Debug.Log("Game Paused");
                Time.timeScale = 0f;
            }
            else
            {
                Debug.Log("Game Resumed");
                Time.timeScale = 1f;
            }
        }

    }

    public void ReloadScene()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Start()
    {
        StartGame();
    }

    void Update()
    {
        PauseGame();
    }

}
