using UnityEngine;
using UnityEngine.InputSystem;

public class Pistol : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 30.0f;

    void Start()
    {

    }

    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
        }

        GameObject[] allBullets = GameObject.FindGameObjectsWithTag("Bullet");

        for (int i = 0; i < allBullets.Length; i++)
        {
            GameObject bullet = allBullets[i];
            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletSpeed);
        }
    }

}
