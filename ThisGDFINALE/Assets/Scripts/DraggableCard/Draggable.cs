using UnityEngine.EventSystems;
using UnityEngine;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform originalPositionObject;

    private Transform originalParent;
    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = originalPositionObject.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        transform.SetParent(transform.parent.parent); // Set the parent to a higher level to make sure it's not occluded by other UI elements
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(originalParent);
        transform.position = originalPosition; // Set the position to the original position
    }
}
