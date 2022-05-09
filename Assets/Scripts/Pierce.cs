using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pierce : MonoBehaviour
{
    public float health = 100.0f;
    public Transform firePoint;
    public GameObject beamPrefab;
    public Transform parent;
    public GameObject beamClone;
    public float timer = 0;
    public int waitingTime = 2;
    public GameObject healthBar;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > waitingTime)
        {
            ShootEnemy();
            timer = 0;
             
        }
        //StartCoroutine(ShootEnemy());

    }
    
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.transform.localScale = new Vector3(health / 100, 1, 1);
        if(health <= 0)
        { 
            Die();
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        } 
    }
    public void Die()
    {
        Destroy(gameObject);
        
    }
    void ShootEnemy()
    {
        beamClone = Instantiate(beamPrefab, firePoint.position, firePoint.rotation);
        beamClone.transform.SetParent(parent);
        
    }
    //IEnumerator ShootEnemy()
    //{
    //    beamClone = Instantiate(beamPrefab, firePoint.position, firePoint.rotation);
    //    beamClone.transform.SetParent(parent);
    //    yield return new WaitForSeconds(2);
    //}
}
