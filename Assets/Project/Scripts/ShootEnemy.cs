using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ShootEnemy : MonoBehaviour
{
    public Button shootButton;
    public Camera fpsCamera;
    public float damage = 50f;
    public GameObject hitEffect;

    // Start is called before the first frame update
    void Start()
    {
        shootButton.onClick.AddListener(Shoot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //raycasting and shooting enemy
    void Shoot()
    {
        RaycastHit hit;
       if( Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit))
        {
            //destroy enemy
            Enemy target = hit.transform.GetComponent<Enemy>();
            if (target != null)
            {
                GameObject shootngEffect = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(shootngEffect, 0.1f);
                target.TakeDamage(damage);
            }
        }
    }
}
