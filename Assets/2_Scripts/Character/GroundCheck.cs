using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    [SerializeField] LayerMask floor;
    bool isGrounded;
    [SerializeField] float radius;

    public bool IsGrounded
    {
        get
        {
            return isGrounded;
        }
    }

    private void Update()
    {
        var col = Physics.OverlapSphere(transform.position, radius,floor);
        isGrounded = col.Length > 0;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
