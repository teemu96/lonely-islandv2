
 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
 public class GuestGiver : MonoBehaviour
{
    public bool onQuest;

    public GameObject questMark;

    public Material questMarkedOn;
    public Material questMarkedOff;

    public Text activE;

    void Start()
    {
        activE.enabled = false;
    }

    void Update()
    {
        if (onQuest)
        {
            questMark.GetComponentInChildren<Renderer>().material = questMarkedOn;
        }
        else
        {
            questMark.GetComponentInChildren<Renderer>().material = questMarkedOff;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            activE.enabled = true;
        }

    }
}