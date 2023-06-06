using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform bulletSpawnPoint;
    public float projectileForce = 10f;
    public TimeSlow timeSlowScript;
    public Animator gunAnimator;
    private GameObject currentGun;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        timeSlowScript = player.GetComponent<TimeSlow>();
        currentGun = gameObject;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

void Fire()
{
    GameObject newProjectile = Instantiate(currentGun.GetComponent<GunController>().projectilePrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
    if (timeSlowScript.isActivated)
    {
        rb.AddForce(transform.right * currentGun.GetComponent<GunController>().projectileForce / 4, ForceMode2D.Impulse);
    }
    else
    {
        rb.AddForce(transform.right * currentGun.GetComponent<GunController>().projectileForce, ForceMode2D.Impulse);
    }

    // Play the projectile animation
    gunAnimator.SetTrigger("Shoot");
    Animator projectileAnimator = newProjectile.GetComponent<Animator>();
    projectileAnimator.Play("Waveform Animation");

    Destroy(newProjectile, 2f);
}


}
