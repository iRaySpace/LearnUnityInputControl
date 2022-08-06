//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""LandAction"",
            ""id"": ""70aed58f-e318-4976-b496-5cd5dd2a5b51"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""289c7638-7279-473c-b4c6-dc2f7b36f1d2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""702aa1ca-48d1-42c6-8877-a092e577c87d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""42989f79-2371-4c65-a352-16a1d7b8076d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b2e6c74-e24d-4fbb-8d73-dfb6e9951eb9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
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
        // LandAction
        m_LandAction = asset.FindActionMap("LandAction", throwIfNotFound: true);
        m_LandAction_Movement = m_LandAction.FindAction("Movement", throwIfNotFound: true);
        m_LandAction_Jump = m_LandAction.FindAction("Jump", throwIfNotFound: true);
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

    // LandAction
    private readonly InputActionMap m_LandAction;
    private ILandActionActions m_LandActionActionsCallbackInterface;
    private readonly InputAction m_LandAction_Movement;
    private readonly InputAction m_LandAction_Jump;
    public struct LandActionActions
    {
        private @PlayerControls m_Wrapper;
        public LandActionActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_LandAction_Movement;
        public InputAction @Jump => m_Wrapper.m_LandAction_Jump;
        public InputActionMap Get() { return m_Wrapper.m_LandAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActionActions set) { return set.Get(); }
        public void SetCallbacks(ILandActionActions instance)
        {
            if (m_Wrapper.m_LandActionActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_LandActionActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_LandActionActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_LandActionActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_LandActionActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LandActionActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LandActionActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_LandActionActionsCallbackInterface = instance;
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
    public LandActionActions @LandAction => new LandActionActions(this);
    public interface ILandActionActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
