using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Fow calculations
/// </summary>
public class FieldOfView : MonoBehaviour
{
    [Range(0, 360)]
    [SerializeField] private float _viewAngle;
    [SerializeField] private float _viewRadius;

    [SerializeField] private LayerMask _targetMask;
    [SerializeField] private LayerMask _obstacleMask;

    [SerializeField] private float _findTargetsDelay;
    public List<Transform> visibleTargets;

    public float ViewRadius
    {
        get => _viewRadius;
    }
    public float ViewAngle
    {
        get => _viewAngle;
    }

    private void Awake()
    {
        visibleTargets = new List<Transform>();
    }

    private void Start()
    {
        StartCoroutine(FindTargetsWithDelay(_findTargetsDelay));
    }

    public Vector3 DirFromAngle(float angleInDegrees, bool angleIsGlobal)
    {
        if (!angleIsGlobal) angleInDegrees += transform.eulerAngles.y;
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }

    // Find tragets with descrete period
    private IEnumerator<WaitForSeconds> FindTargetsWithDelay(float delay)
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            FindVisibleTargets();
        }
    }
    private void FindVisibleTargets()
    {
        visibleTargets.Clear();
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, _viewRadius, _targetMask);

        for(int i = 0; i < targetsInViewRadius.Length; i++)
        {
            Transform target = targetsInViewRadius[i].transform;
            Vector3 dirToTarget = (target.position - transform.position).normalized;
            if(Vector3.Angle(transform.forward, dirToTarget) < _viewAngle / 2)
            {
                float distToTarget = Vector3.Distance(transform.position, target.position);

                // If there are no obstacles on the way to target
                if(!Physics.Raycast(transform.position, dirToTarget, distToTarget, _obstacleMask))
                {
                    visibleTargets.Add(target);
                }
            }
        }
    }
}
