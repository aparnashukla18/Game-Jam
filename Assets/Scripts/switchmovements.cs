using UnityEngine;

public class switchmovements : MonoBehaviour
{
    public MonoBehaviour MovementToEnable;
    public MonoBehaviour MovementToDisable;


    void Awake()
    {
        Debug.Log("switchmovement running");
        if (MovementToEnable == null || MovementToDisable == null)
        {
            Debug.LogError("assign both scripts");
            return;
        }
        MovementToEnable.enabled = true;
        MovementToDisable.enabled = false;

        //Debug.Log(" topdown flip movement ");
    }
}
