using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadNewGame : MonoBehaviour
{
    public Button newGame;
    // Start is called before the first frame update
    void Start()
    {
        newGame.onClick.AddListener(NewGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NewGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    
}
