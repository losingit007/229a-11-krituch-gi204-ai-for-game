using UnityEngine;

public class PlaneFly : MonoBehaviour
{
    private ConstantForce constantForce;

    void Start()
    {
        constantForce = GetComponent<ConstantForce>();
        if (constantForce == null)
        {
            constantForce = gameObject.AddComponent<ConstantForce>();
        }

        constantForce.force = new Vector3(10f, 0f, 0f);
    }
}
