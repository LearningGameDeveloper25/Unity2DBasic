using UnityEngine;

public class _EnemyCotroller : MonoBehaviour
{
    public _Despawner _despawner;

    private void Awake()
    {
        this._despawner = GetComponent<_Despawner>();
    }
}
