using UnityEngine;

public class SuccessTrigger : MonoBehaviour
{
    public GameObject text;

    private void OnTriggerEnter(Collider other)
    {
        text.SetActive(true);
    }
}
