using UnityEngine;

public class SuccessTrigger : MonoBehaviour
{
    public GameObject text; // 1 

    private void OnTriggerEnter(Collider other)
    {
        text.SetActive(true); // 2 
    }
}