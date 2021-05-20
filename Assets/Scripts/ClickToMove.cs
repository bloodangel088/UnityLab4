using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickToMove : MonoBehaviour
{
    public GameObject tutorial;
    private Animator animator;
    private bool running = false;
    private NavMeshAgent NavMeshAgent;
    static public int coins;

    [SerializeField]
    public Text textCoins;
    void Start()
    {
        coins = 0;
        animator = GetComponent<Animator>();
        NavMeshAgent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            tutorial.SetActive(false);


        textCoins.text = coins.ToString();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        if(Time.timeScale == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(ray, out hit, 100))
                {
                    NavMeshAgent.destination = hit.point;
                }
            }
            if (NavMeshAgent.remainingDistance <= NavMeshAgent.stoppingDistance)
            {
                running = false;
            }
            else
                running = true;

            animator.SetBool("running", running);
        }
        
    }

}