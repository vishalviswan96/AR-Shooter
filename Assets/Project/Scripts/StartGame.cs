using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button startButton;
    public PlaceOnPlane placeOnPlane;
    public GameObject startObject;
    public Image instruction;
    
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartNewGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StartNewGame()
    {
        placeOnPlane = GetComponent<PlaceOnPlane>();
        Destroy(placeOnPlane);
        startButton.gameObject.SetActive(false);
        instruction.gameObject.SetActive(false);
        startObject.gameObject.SetActive(true);

    }
}
