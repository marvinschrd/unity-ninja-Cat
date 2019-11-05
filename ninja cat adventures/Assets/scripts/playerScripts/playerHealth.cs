using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{


    [SerializeField]
    float maxHealth;
    float currentHealth;
    

    public bool outOfMap = false;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (outOfMap == true)
        {
            currentHealth -= 1;
            //  Debug.Log("Current health = "  currentHealth);
        }
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
        outOfMap = false;
    }
    public void TakeDamage(int dmg)
    {
        currentHealth -= dmg;

    }
    //public void AttackSelf(int dmg)
    //{
    //    currentHealth -= dmg;

    //    Debug.Log("Current health = " + currentHealth);

    //    if (currentHealth <= 0)
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}




