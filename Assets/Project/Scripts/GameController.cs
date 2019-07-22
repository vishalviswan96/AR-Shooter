using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject bloodScreen;
    public Text healthText;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void EnemyAttack(bool enemyIsThere)
    {
        Debug.Log("here");
        bloodScreen.gameObject.SetActive(true);
        StartCoroutine(WaitForNextAttack());

        health -= 10;
        string stringHealth = (health).ToString();
        healthText.text = " " + stringHealth;
    }
    //2sec wait for next attack
    IEnumerator WaitForNextAttack()
    {
        yield return new WaitForSeconds(2f);
        bloodScreen.gameObject.SetActive(false);
    }
}
