using UnityEngine;

public class _PlayerDamgeReceiver : _DamgeReceiver
{
    protected _PlayerController _playerCtrl;

    private void Awake()
    {
        _playerCtrl = GetComponent<_PlayerController>();
    }

    public override void Receive(int damge)
    {
        base.Receive(damge);
        if (this.IsDead())
        _UIManager.instance.btnRestart.SetActive(true);
        this._playerCtrl._playerStatus.Dead();
    }
}
