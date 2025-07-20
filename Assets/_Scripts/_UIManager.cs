using UnityEngine;

public class _UIManager : MonoBehaviour
{
    public GameObject btnRestart;
    static public _UIManager instance;

    private void Awake()
    {
        _UIManager.instance = this;
        btnRestart = GameObject.Find("btnRestart");
        this.btnRestart.SetActive(false);
    }
}
