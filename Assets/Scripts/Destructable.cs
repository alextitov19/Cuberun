using UnityEngine;

public class Destructable : MonoBehaviour
{
    public GameObject destroyedVersion;
    public Vector3 translocation;
    public void swapToBroken()
    {
        Debug.Log("Enter swaptobroken");
        Instantiate(destroyedVersion, transform.position + translocation, transform.rotation);
        Destroy(gameObject);
        Debug.Log("Exit swaptobroken");
    }
}
