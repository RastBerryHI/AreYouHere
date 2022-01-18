using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public enum BehaviorStates : sbyte
{
    Idle,
    Chase,
    Search
}

public class EnemyBenavior : MonoBehaviour
{
    public static EnemyBenavior s_instance;

    [SerializeField] private Transform _enemyHost;
    [SerializeField] private BehaviorStates _state;
    [SerializeField] private int _searchPointAmount;

    private Controller _controller;
    private FieldOfView _fieldOfView;
    private bool b_isCountedOnce = false;

    public UnityAction<BehaviorStates> onBehaviorStateChange;

    private void Awake()
    {
        if (s_instance == null)
        {
            s_instance = this;
        }
        else
        {
            DestroyImmediate(s_instance.gameObject);
        }

        //if(_searchPointAmount <= 0 || _searchPointAmount > _controller.seekPoints.Count)
        //{
        //    Debug.LogError("Set searchPointAmount to value less than seekPoints count");
        //}

        _controller = GetComponent<Controller>();
        _fieldOfView = GetComponent<FieldOfView>();
    }

    private void Start()
    {
        onBehaviorStateChange += ChangeBehaviorSate;
    }

    private void Update()
    {
        switch (_state)
        {
            case BehaviorStates.Idle:
                _controller.MoveToTarget(_enemyHost.position);
                break;
            case BehaviorStates.Chase:
                // if enemy sees target
                if (_fieldOfView.visibleTargets.Count > 0)
                {
                    _fieldOfView.lastSeenPosition = _fieldOfView.visibleTargets[0].position;
                    _controller.MoveToTarget(_fieldOfView.visibleTargets[0].position);
                }
                else
                {
                    onBehaviorStateChange(BehaviorStates.Search);
                }
                break;
            case BehaviorStates.Search:
                // TODO: patrol
                if (b_isCountedOnce == false)
                {
                    for (int i = 0; i < _searchPointAmount; i++)
                    {
                        _controller.searchPoints.Add(_controller.allPoints[Random.Range(0, _controller.allPoints.Count-1)]);
                    }
                    b_isCountedOnce = true;
                }
                _controller.GoToNextPoint();
                break;
        }
    }


    private void ChangeBehaviorSate(BehaviorStates behavior)
    {
        _state = behavior;
        b_isCountedOnce = false;
        _controller.searchPoints.Clear();
    }
}
