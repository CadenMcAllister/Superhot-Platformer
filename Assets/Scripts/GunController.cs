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
    if (currentGun.name == "laser_red" || currentGun.name == "Laser Pistol"){
        projectileAnimator.Play("Bolt Animation");
    }

    else if (currentGun.name == "Blaster"){

        projectileAnimator.Play("Waveform Animation");

    }

    else if (currentGun.name == "Rocket Launcher"){

        projectileAnimator.Play("Charged Animation");

    }

    else if (currentGun.name == "MachineGun"){
        projectileAnimator.Play("Pulse Animation");
    }

    Destroy(newProjectile, 2f);
}


}
