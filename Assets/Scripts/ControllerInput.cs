//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.1
//     from Assets/Scripts/ControllerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ControllerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControllerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControllerInput"",
    ""maps"": [
        {
            ""name"": ""2DGame"",
            ""id"": ""fce5de09-54c1-495c-928b-d411f0a68d11"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""29fa33ca-9c1a-4910-b4da-5c2f9063a67d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0ed2a821-d0bf-40c1-af9c-1fd43653b566"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a115f602-9a53-471a-ab84-7f4efbba9f8d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c2cf386a-1c40-4f64-88db-23e3705153a1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5180d943-f6ea-478a-be85-36b26f155564"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""98b06e0e-61aa-4f15-8432-bd167babfdfd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // 2DGame
        m__2DGame = asset.FindActionMap("2DGame", throwIfNotFound: true);
        m__2DGame_Movement = m__2DGame.FindAction("Movement", throwIfNotFound: true);
        m__2DGame_Jump = m__2DGame.FindAction("Jump", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // 2DGame
    private readonly InputActionMap m__2DGame;
    private I_2DGameActions m__2DGameActionsCallbackInterface;
    private readonly InputAction m__2DGame_Movement;
    private readonly InputAction m__2DGame_Jump;
    public struct _2DGameActions
    {
        private @ControllerInput m_Wrapper;
        public _2DGameActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m__2DGame_Movement;
        public InputAction @Jump => m_Wrapper.m__2DGame_Jump;
        public InputActionMap Get() { return m_Wrapper.m__2DGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_2DGameActions set) { return set.Get(); }
        public void SetCallbacks(I_2DGameActions instance)
        {
            if (m_Wrapper.m__2DGameActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m__2DGameActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m__2DGameActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m__2DGameActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m__2DGameActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m__2DGameActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m__2DGameActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m__2DGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public _2DGameActions @_2DGame => new _2DGameActions(this);
    public interface I_2DGameActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
