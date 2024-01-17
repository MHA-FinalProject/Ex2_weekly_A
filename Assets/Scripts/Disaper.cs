using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Disappear : MonoBehaviour
{
    [SerializeField]
    InputAction Dissaper = new InputAction(type: InputActionType.Button);

    void OnEnable()
    {
        Dissaper.Enable();
    }

    void OnDisable()
    {
        Dissaper.Disable();
    }


    private void Update()
    {
        if (Dissaper.WasPressedThisFrame())
        {
            GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
        }
    }
}
