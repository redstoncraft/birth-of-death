using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{
    [SerializeField]
    KeyCode giveDmg;
    [SerializeField]
    KeyCode giveDmgPS;
    [SerializeField]
    string strSceneName;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    private GameMaster gm;
    private GameMaster gmp;

    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
        gmp = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(giveDmg))
        {
            TakeDamage(1);
        }

        if(Input.GetKey(giveDmgPS))
        {
            TakeDamage(1);
        }
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Coin"))
        {
            Destroy(col.gameObject);
            gm.gems += 1;
        }

        if(col.CompareTag("Point"))
        {
            Destroy(col.gameObject);
            gmp.points += 1;
        }

        if(col.CompareTag("Finish"))
        {
            SceneManager.LoadScene(strSceneName);
        }
    }

}
