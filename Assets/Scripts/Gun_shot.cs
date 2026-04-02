using UnityEngine;

public class Gun_shot : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePoint;
    public float Speed = 20f;
    public float LifeTime = 6f;

    public AudioClip clip;
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    public void FireBullet()
    {
        GameObject bullet = Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
        Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();

        rigidbody.linearVelocity = FirePoint.forward * Speed;

        source.PlayOneShot(clip);

        Destroy(bullet, LifeTime);
    }

}
