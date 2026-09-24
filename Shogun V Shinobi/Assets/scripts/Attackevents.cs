using UnityEngine;

public class Attackevents : MonoBehaviour
{
    public AttackHitbox attackHitbox; // Reference to the AttackHitbox script
    
    public void EnableHitbox()
    {
        attackHitbox.EnableHitbox();
    }

    public void DisableHitbox()
    {
        attackHitbox.DisableHitbox();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
