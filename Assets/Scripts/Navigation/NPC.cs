using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private NpcState npcState;

    public Transform target;
    public float FOV = 45.0f;
    public float Range = 30.0f;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        EventManager.Instance.Subscribe("GameOver", OnGameOver);
    }

    private void OnEnable()
    {
        StartCoroutine(NPCRoutine());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private IEnumerator NPCRoutine()
    {
        npcState = NpcState.Search;

        while (true)
        {
            switch (npcState)
            {
                case NpcState.Search:
                    yield return Search();
                    break;
                case NpcState.Chase:
                    yield return Chase();
                    break;
                case NpcState.Attack:
                    yield return Attack();
                    break;
            }

            yield return null;
        }
    }

    private IEnumerator Search()
    {
        Vector3 direction = Random.insideUnitSphere;
        Vector3 dest = 20.0f * direction + transform.position;

        NavMesh.SamplePosition(dest, out NavMeshHit hit, 5.0f, NavMesh.AllAreas);
        navMeshAgent.destination = hit.position;

        while (navMeshAgent.remainingDistance > 1.0f)
        {
            Vector3 toTarget = target.position - transform.position;
            float degree = Mathf.Acos(Vector3.Dot(toTarget.normalized, transform.forward)) * Mathf.Rad2Deg;

            Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo);

            if (degree < FOV && toTarget.magnitude < Range)
            {
                if (hitInfo.collider)
                {
                    if (hitInfo.collider.gameObject.name == "Target")
                    {
                        npcState = NpcState.Chase;
                        break;
                    }
                }
            }

            yield return null;
        }
    }

    private IEnumerator Chase()
    {
        navMeshAgent.destination = target.position;

        while (navMeshAgent.remainingDistance > 5.0f)
        {
            navMeshAgent.destination = target.position;

            yield return null;
        }

        npcState = NpcState.Attack;
    }

    private IEnumerator Attack()
    {
        while (navMeshAgent.remainingDistance < 5.0f)
        {
            navMeshAgent.destination = target.position;

            print("Attack!");

            yield return null;
        }

        npcState = NpcState.Search;
    }

    private void OnGameOver(object param)
    {
        gameObject.SetActive(false);
    }
}
