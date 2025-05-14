using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 10f;  // Kecepatan pergerakan musuh (seperti peluru)
    public float lifespan = 5f;    // Waktu hidup musuh sebelum dihancurkan
    private Vector3 moveDirection; // Arah pergerakan musuh

    private void Start()
    {
        // Arah pergerakan hanya ke kiri (X negatif)
        moveDirection = new Vector3(-1f, 0f, 0f).normalized; // Gerakan ke kiri di sumbu X

        Destroy(gameObject, lifespan); // Musuh akan dihancurkan setelah beberapa detik
    }

    private void Update()
    {
        // Pergerakan musuh ke arah kiri
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Jika musuh terkena pemain
        //if (collision.gameObject.CompareTag("Player"))
        //{
        //    PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
        //    if (player != null)
        //    {
        //        player.TakeDamage(1);  
        //    }

        //    Destroy(gameObject);
        //}
    }
}
