//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/Controles.inputactions
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

namespace GameInputs
{
    public partial class @GameInput: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controles"",
    ""maps"": [
        {
            ""name"": ""MainPlayer"",
            ""id"": ""3edc5cab-6bfe-46b5-b2f7-a5e24ab804d0"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""09bad414-acbe-425b-8d5f-b6c9b0c66d9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Chat"",
                    ""type"": ""Button"",
                    ""id"": ""ac07ded3-f037-42c1-a98d-069b3b38f19a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a04cb810-3fe2-4386-9672-92e9960568e0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventario"",
                    ""type"": ""Button"",
                    ""id"": ""acfb84d3-8bb6-4aea-b25f-2c4f71a9866c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""389997dd-c953-459b-8e0f-9759579d17c5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a2222e77-2cf5-4fa6-8728-ebf20e2244f1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a788f635-b2da-432b-8b2b-e7cf7da7abe7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c85a878c-f0c7-45b3-8a43-225ad229df61"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c1b27a7f-af9f-4782-9ddf-5dd4215dd195"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8c67d7fb-0a0b-468c-af20-285998588be6"",
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
                    ""id"": ""f2534170-6b5f-4056-aeaa-4529792d1c19"",
                    ""path"": ""<Keyboard>/#(E)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Chat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab12065d-94eb-46c4-9e74-437fa44f6fbc"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventario"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // MainPlayer
            m_MainPlayer = asset.FindActionMap("MainPlayer", throwIfNotFound: true);
            m_MainPlayer_Attack = m_MainPlayer.FindAction("Attack", throwIfNotFound: true);
            m_MainPlayer_Chat = m_MainPlayer.FindAction("Chat", throwIfNotFound: true);
            m_MainPlayer_Movement = m_MainPlayer.FindAction("Movement", throwIfNotFound: true);
            m_MainPlayer_Inventario = m_MainPlayer.FindAction("Inventario", throwIfNotFound: true);
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

        // MainPlayer
        private readonly InputActionMap m_MainPlayer;
        private List<IMainPlayerActions> m_MainPlayerActionsCallbackInterfaces = new List<IMainPlayerActions>();
        private readonly InputAction m_MainPlayer_Attack;
        private readonly InputAction m_MainPlayer_Chat;
        private readonly InputAction m_MainPlayer_Movement;
        private readonly InputAction m_MainPlayer_Inventario;
        public struct MainPlayerActions
        {
            private @GameInput m_Wrapper;
            public MainPlayerActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Attack => m_Wrapper.m_MainPlayer_Attack;
            public InputAction @Chat => m_Wrapper.m_MainPlayer_Chat;
            public InputAction @Movement => m_Wrapper.m_MainPlayer_Movement;
            public InputAction @Inventario => m_Wrapper.m_MainPlayer_Inventario;
            public InputActionMap Get() { return m_Wrapper.m_MainPlayer; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MainPlayerActions set) { return set.Get(); }
            public void AddCallbacks(IMainPlayerActions instance)
            {
                if (instance == null || m_Wrapper.m_MainPlayerActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_MainPlayerActionsCallbackInterfaces.Add(instance);
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Chat.started += instance.OnChat;
                @Chat.performed += instance.OnChat;
                @Chat.canceled += instance.OnChat;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Inventario.started += instance.OnInventario;
                @Inventario.performed += instance.OnInventario;
                @Inventario.canceled += instance.OnInventario;
            }

            private void UnregisterCallbacks(IMainPlayerActions instance)
            {
                @Attack.started -= instance.OnAttack;
                @Attack.performed -= instance.OnAttack;
                @Attack.canceled -= instance.OnAttack;
                @Chat.started -= instance.OnChat;
                @Chat.performed -= instance.OnChat;
                @Chat.canceled -= instance.OnChat;
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @Inventario.started -= instance.OnInventario;
                @Inventario.performed -= instance.OnInventario;
                @Inventario.canceled -= instance.OnInventario;
            }

            public void RemoveCallbacks(IMainPlayerActions instance)
            {
                if (m_Wrapper.m_MainPlayerActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IMainPlayerActions instance)
            {
                foreach (var item in m_Wrapper.m_MainPlayerActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_MainPlayerActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public MainPlayerActions @MainPlayer => new MainPlayerActions(this);
        public interface IMainPlayerActions
        {
            void OnAttack(InputAction.CallbackContext context);
            void OnChat(InputAction.CallbackContext context);
            void OnMovement(InputAction.CallbackContext context);
            void OnInventario(InputAction.CallbackContext context);
        }
    }
}