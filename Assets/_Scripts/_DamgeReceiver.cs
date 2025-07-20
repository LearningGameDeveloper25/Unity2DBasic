using UnityEngine;

public class _DamgeReceiver : MonoBehaviour
{
    protected int hp = 3;

    public virtual void Receive(int damage)
    {
        this.hp  -= damage; 
    }

    public virtual bool IsDead()
    {
        if (this.hp <= 0) return true;
        return false;
    }
}
