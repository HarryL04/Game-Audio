using UnityEngine;
using UnityEngine.EventSystems;
using FMODUnity;

public class UIHoverSound : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private EventReference hoverSoundEvent; // strongly-typed reference

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hoverSoundEvent.IsNull == false)
        {
            RuntimeManager.PlayOneShot(hoverSoundEvent);
        }
    }
}
