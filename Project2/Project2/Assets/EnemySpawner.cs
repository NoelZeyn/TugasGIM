using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 10;
    public float minY = -2.882f;  // Batas bawah Y
    public float maxY = 0.1f;     // Batas atas Y

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Menentukan posisi spawn dengan X tetap 14 dan Y acak antara minY dan maxY
        Vector3 spawnPosition = new Vector3(
            14f, // X tetap di 14
            Random.Range(minY, maxY), // Y acak antara minY dan maxY
            transform.position.z // Z biasanya 0 pada 2D
        );

        // Membuat musuh di posisi spawn
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
