using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnController : MonoBehaviour
{
    public GameObject enemy;
   // public Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        //startButton.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Enemy spawn on pressing start button
    public void StartGame()
    {
        InvokeRepeating("Spawn", 0, 3f);
    }
    void Spawn()
    {
        Vector3 position = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
        Instantiate(enemy, position, Quaternion.Euler(0, 0, 0));
    }
}
