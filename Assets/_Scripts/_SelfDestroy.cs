using UnityEngine;

public class _SelfDestroy : MonoBehaviour
{
    private void Start()
    {
        Invoke("Destroy", 5f);
    }

    protected virtual void Destroy()
    {
        Destroy(gameObject);
    }
}
