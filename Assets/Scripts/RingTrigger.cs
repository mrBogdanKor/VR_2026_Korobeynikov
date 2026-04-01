using UnityEngine;

public class RingTrigger : MonoBehaviour
{
    public GameObject Fx;
    private void OnTriggerExit(Collider other)
    {
       Instantiate(Fx, transform.parent); 
    }
}
