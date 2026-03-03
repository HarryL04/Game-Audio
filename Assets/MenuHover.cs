using UnityEngine;
using UnityEngine.EventSystems;
using FMODUnity;

public class MenuHover : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField]public EventReference hoverEvent;

    public void OnPointerEnter(PointerEventData eventData)
    {
        RuntimeManager.PlayOneShot(hoverEvent);
    }
}
