using UnityEngine;

public class TestTarget : MonoBehaviour
{
    public void HitTarget()
    {
        Debug.Log("AR Target Hit!");
        Destroy(gameObject);
    }
}
