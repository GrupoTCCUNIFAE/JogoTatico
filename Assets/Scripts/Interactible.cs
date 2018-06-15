using UnityEngine;
using UnityEngine.AI;

/*	
	This component is for all objects that the player can
	interact with such as enemies, items etc. It is meant
	to be used as a base class.
*/

[RequireComponent(typeof(NavMeshAgent))]
public class Interactable : MonoBehaviour
{

    public float radius = 10f;               // How close do we need to be to interact?
	public float atackRadius = 3f;
    public Transform interactionTransform;  // The transform from where we interact in case you want to offset it

    bool isFocus = false;   // Is this interactable currently being focused?
    Transform player;       // Reference to the player transform

    bool hasInteracted = false; // Have we already interacted with the object?

	public float delayDoAtaque = 10f;

	private float tempo;
	public NavMeshAgent agent;

	void Start(){
		tempo = delayDoAtaque;
		//agent = GetComponent<NavMeshAgent> ();
	}

    public virtual void Interact()
    {
        // This method is meant to be overwritten
        //Debug.Log("Interacting with " + transform.name);
    }

    void Update()
    {
		if (tempo > 0) {
			tempo -= Time.deltaTime;
		}

		if (Vector3.Distance(transform.position, PlayerManager.instance.player.transform.position) <= radius) {
			OnFocused (PlayerManager.instance.player.transform);
		} else {
			OnDefocused ();
		}
        // If we are currently being focused
        // and we haven't already interacted with the object
        if (isFocus)
        {
            // If we are close enough
            float distance = Vector3.Distance(player.position, interactionTransform.position);
			if (distance <= atackRadius && tempo <= 0)
            {
                // Interact with the object
                Interact();
                hasInteracted = true;
				tempo = delayDoAtaque;
            }
			if (distance <= radius) {
				agent.SetDestination (player.position);
			}
        }
    }

    // Called when the object starts being focused
    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    // Called when the object is no longer focused
    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }

    // Draw our radius in the editor
    void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }



}