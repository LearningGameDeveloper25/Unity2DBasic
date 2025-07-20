using UnityEngine;

public class _For : MonoBehaviour
{
    void Start()
    {
        int maxMinion = 10;
        for (int i = 0; i <= maxMinion; i += 2)
        {
            this.Spawn(i);
        }
    }

    void Spawn(int i)
    {
        //Debug.Log(i);
    }
}
