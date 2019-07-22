using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithCamera : MonoBehaviour
{
    public bool enemyIsThere;
    public float timer;
    public float timeBetweenAttacks = 2f;
    private GameController gameController;
    public AudioSource attackSound;

    
   
    void Start()
    {
        //referencing game controller to the script
        GameObject gameConrollerObject = GameObject.FindGameObjectWithTag("GameController");
        if(gameConrollerObject != null)
        {
            gameController = gameConrollerObject.GetComponent<GameController>();
        }
        AudioSource attackSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (enemyIsThere && timer >= timeBetweenAttacks)
        {
            Attack();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MainCamera")
        {
            enemyIsThere = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "MainCamera")
        {
            enemyIsThere = false;
        }
    }

    void Attack()
    {
        timer = 0f;
        GetComponent<Animator>().Play("Attack");
        attackSound.Play();
        gameController.EnemyAttack(enemyIsThere);
        
    }

    
}
