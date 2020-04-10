using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAndRespawn : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    public Vector3 respawnPoint;
    private int currentHealth;
    [SerializeField] private float minimumHeight;

    private CharacterController charController;


    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        CheckForRespawn();
        CheckForOutOfBounds();
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
        charController.velocity.Set(0,0,0);
        transform.position = respawnPoint;
        currentHealth = maxHealth;
    }
}
