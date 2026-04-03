using UnityEngine;

[RequireComponent(typeof(Gun_shot))]
public class Machinegun : MonoBehaviour
{
    public Gun_shot pistol;
    public float timer;
    public bool isFire;
    void Start()
    {
        pistol = GetComponent<Gun_shot>();
    }


    void Update()
    {
        if (isFire == true)
        {
            timer += Time.deltaTime;
            if (timer > 0.3f)
            {
                pistol.FireBullet();
                timer = 0f;
            }
        }
    }

    public void FireOn()
    {
        isFire = true;
    }

    public void FireOff()
    {
        isFire = false;
    }
}
