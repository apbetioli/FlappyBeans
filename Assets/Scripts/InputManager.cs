// GENERATED AUTOMATICALLY FROM 'Assets/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""Bird"",
            ""id"": ""a98a9035-641f-45db-af06-b93c62242436"",
            ""actions"": [
                {
                    ""name"": ""Flap"",
                    ""type"": ""Button"",
                    ""id"": ""19f1fc90-b112-4c60-8872-75972d366b05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""45e67b29-f03c-4249-b615-a4aa9f24aeae"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7abdf0e-e0fe-48c1-a568-56aff4d50c4b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dec29ce3-1465-4268-87b3-e8aab96b04b6"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01afb57f-0e4c-45d1-9fcf-af9c28feab0e"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Flap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Bird
        m_Bird = asset.FindActionMap("Bird", throwIfNotFound: true);
        m_Bird_Flap = m_Bird.FindAction("Flap", throwIfNotFound: true);
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

    // Bird
    private readonly InputActionMap m_Bird;
    private IBirdActions m_BirdActionsCallbackInterface;
    private readonly InputAction m_Bird_Flap;
    public struct BirdActions
    {
        private @InputManager m_Wrapper;
        public BirdActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Flap => m_Wrapper.m_Bird_Flap;
        public InputActionMap Get() { return m_Wrapper.m_Bird; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BirdActions set) { return set.Get(); }
        public void SetCallbacks(IBirdActions instance)
        {
            if (m_Wrapper.m_BirdActionsCallbackInterface != null)
            {
                @Flap.started -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlap;
                @Flap.performed -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlap;
                @Flap.canceled -= m_Wrapper.m_BirdActionsCallbackInterface.OnFlap;
            }
            m_Wrapper.m_BirdActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Flap.started += instance.OnFlap;
                @Flap.performed += instance.OnFlap;
                @Flap.canceled += instance.OnFlap;
            }
        }
    }
    public BirdActions @Bird => new BirdActions(this);
    public interface IBirdActions
    {
        void OnFlap(InputAction.CallbackContext context);
    }
}
