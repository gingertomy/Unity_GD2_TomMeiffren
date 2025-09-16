using UnityEngine;

public class Target_Soft : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player_Collect>() != null)
        {
           
            Destroy(gameObject);
        }
    }
}