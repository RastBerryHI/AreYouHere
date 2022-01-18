using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _moveDescreteMagnitude;

    public List<Transform> allPoints;
    public List<Transform> searchPoints;
    private NavMeshAgent _navMeshAgent;
    private Transform lastPoint;
    private bool b_isDeleted = false;

    public float Velocity
    {
        get => _navMeshAgent.velocity.magnitude;
    }

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        allPoints = GameObject.FindGameObjectsWithTag("SeekPoint"). ToList<GameObject>().Select(go => go.transform).ToList<Transform>();
    }

    private IEnumerator<WaitForSeconds> MoveToTargetDelay(float delay, Vector3 position)
    {
        yield return new WaitForSeconds(delay);
        _navMeshAgent.speed = _moveSpeed;
        _navMeshAgent.destination = position;
    }

    /// <summary>
    /// Moves enemy to target position
    /// </summary>
    /// <param name="targetPosition"> position to move to </param>
    public void MoveToTarget(Vector3 targetPosition)
    {
        StartCoroutine(MoveToTargetDelay(_moveDescreteMagnitude, targetPosition));
    }
    public void GoToNextPoint()
    {
        if (searchPoints.Count == 0) return;
        lastPoint = searchPoints.Last<Transform>();

        if(_navMeshAgent.remainingDistance == 0 && b_isDeleted == false)
        {
            searchPoints.Remove(lastPoint);
            b_isDeleted = true;
        }

        if (!_navMeshAgent.pathPending && Mathf.Round(_navMeshAgent.remainingDistance) < 1f)
        {
            StartCoroutine(GoToNextOintDelay());
        }
        else
        {
            b_isDeleted = false;
        }

    }

    private IEnumerator<WaitForSeconds> GoToNextOintDelay()
    {
        yield return new WaitForSeconds(4);

        if (searchPoints.Count == 0) GetComponent<EnemyBenavior>().onBehaviorStateChange(BehaviorStates.Idle);
        else MoveToTarget(lastPoint.position);
    }
}
