using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _cGM;

    public bool bPaused = false;


    public void Awake()
    {
        _cGM = this;
    }

    public void StartGame()
    {
        Debug.Log("GameManager start");
    }

    public void PauseGame()
    {
        if(Input.GetKey(KeyCode.Q))
        {
            Debug.Log("GameManager paused");
            bPaused = true;
        }

    }

    void Update()
    {
        PauseGame();
    }

}
