using UnityEngine;

public class _PlayerController : MonoBehaviour
{
    public static _PlayerController instance;
    public _PlayerStatus _playerStatus;
    public _DamgeReceiver _damgeReceiver;

    private void Awake()
    {
        _PlayerController.instance = this;

        this._playerStatus = GetComponent<_PlayerStatus>();
        this._damgeReceiver = GetComponent<_DamgeReceiver>();
    }
}
