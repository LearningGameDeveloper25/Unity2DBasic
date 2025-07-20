using Unity.VisualScripting;
using UnityEngine;

public class _PlayerStatus : MonoBehaviour
{
    public virtual void Dead()
    {
        Debug.Log("Player is dead");
    }
}
