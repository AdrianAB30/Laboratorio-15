using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradordeBalas : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    private Rigidbody rbd;
    public AudioSource sonidoDisparo;
    public float bulletSpeed = 10f;
    public GameManager gameManager;
    void Awake()
    {
    }

    void Update()
    {
        
    }
    public void Disparar()
    {
        if (bulletPrefab != null && spawnPoint != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
            bullet.GetComponent<Bullet>().SetSpawnBullet(this);
            sonidoDisparo.Play();
        }
    }
    public void SumarPuntos(int addPoints)
    {
        gameManager.SumarPuntos(addPoints);
    }
}
