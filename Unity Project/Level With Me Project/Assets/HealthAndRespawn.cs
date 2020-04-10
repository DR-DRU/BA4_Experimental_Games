using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAndRespawn : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    public Vector3 respawnPoint;
    private int currentHealth;
    [SerializeField] private float minimumHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckForRespawn();
    }

    void CheckForOutOfBounds()
    {
        if (transform.position.y < minimumHeight)
        {
            Respawn();
        }
    }

    void CheckForRespawn()
    {
        if (currentHealth <= 0)
        {
            Respawn();
        }
    }

    void Respawn()
    {

        transform.position = respawnPoint;
        currentHealth = maxHealth;
    }
}
