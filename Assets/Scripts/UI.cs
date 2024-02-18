using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Button restartButton;
    public GameObject gameoverPanel;
    public Control control;
    
    void Start()
    {
        gameoverPanel.SetActive(false);
        restartButton.onClick.AddListener(Restart);
    }

    
    void Update()
    {
        if (control.isDead == true)
        {
            Time.timeScale = 0;
            gameoverPanel.SetActive(true);
        }
        
    }

    public void Restart()
    {
        Time.timeScale = 1;
        
        gameoverPanel.SetActive(false);
        control.isDead = false;
        SceneManager.LoadScene(0);
    }
}
