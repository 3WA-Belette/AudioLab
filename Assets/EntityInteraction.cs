using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class EntityInteraction : MonoBehaviour
{
    [SerializeField] InputActionReference _clickInput;

    [SerializeField] TextMeshProUGUI _focusName;
    [SerializeField] Image _cursor;

    [SerializeField] Sprite _emptyCursor;
    [SerializeField] Color _emptyColor;

    [SerializeField] Sprite _lockedCursor;
    [SerializeField] Color _lockedColor;

    IUsable _focus;

    private void Start()
    {
        _clickInput.action.started += UseComponent;
    }

    private void UseComponent(InputAction.CallbackContext obj)
    {
        if(_focus != null)
        {
            _focus.Use();
        }
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward*2, Color.yellow);
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 2f))
        {
            {
            /*
            if (hit.collider.TryGetComponent<Button>(out var button))
            {
                button.Push();
            }

            if (hit.collider.TryGetComponent<Lever>(out var lever))
            {
                button.Activate();
            }

            if (hit.collider.TryGetComponent<NPC>(out var npc))
            {
                button.Talk();
            }
            */
            }

            if (hit.collider.TryGetComponent<IUsable>(out IUsable usableComponent))
            {
                ShowInteraction(usableComponent);
                _focus = usableComponent;
            }
            else
            {
                HideInteraction();
                _focus = null;
            }
        }
        else
        {
            HideInteraction();
            _focus = null;
        }
    }

    void ShowInteraction(IUsable usableComponent)
    {
        _cursor.sprite = _lockedCursor;
        _cursor.color = _lockedColor;
        _focusName.text = usableComponent.GetName();
    }
    void HideInteraction()
    {
        _cursor.sprite = _emptyCursor;
        _cursor.color = _emptyColor;
        _focusName.text = "";
    }

}
