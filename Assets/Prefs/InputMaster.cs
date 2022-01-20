// GENERATED AUTOMATICALLY FROM 'Assets/Prefs/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""87ccdc58-46cd-4632-8cb2-e569ecab8cda"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""bf508440-540c-482c-8ec6-770844e27a7a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""293bd00c-d175-47ea-a49c-388a1bc12104"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fb2acba8-5963-4f37-a07c-e94b9b4f7abf"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TakeFlashlight"",
                    ""type"": ""Button"",
                    ""id"": ""38c3d2fd-1dd1-4212-8d6a-1d5372077a87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""38a991e4-ce4f-4868-8f71-e1e2eb83759d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""70db69a9-24a0-4461-86af-4acd3e233eba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TakeWalkie"",
                    ""type"": ""Button"",
                    ""id"": ""2a3bc0ea-4273-426b-87d1-a539e280724c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interract"",
                    ""type"": ""Button"",
                    ""id"": ""0d920f6f-03c4-4d8a-80c3-bd4bc07092dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseL"",
                    ""type"": ""Button"",
                    ""id"": ""7187394e-9636-41af-bec5-415dbbb700c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseDrag"",
                    ""type"": ""Value"",
                    ""id"": ""68f2130e-9c0b-4433-86be-16f5e4dcf426"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0c19e763-3775-434e-a0d0-a1cb6d3dcbd7"",
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
                    ""id"": ""a6721fb2-e54c-4256-99e8-d2a45f963e8c"",
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
                    ""id"": ""0e76221f-d817-45dd-84f8-ee5e38923ad6"",
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
                    ""id"": ""ac05868e-fbdb-400b-b7f4-8adcadaf2be2"",
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
                    ""id"": ""475c43e7-78a8-486b-ae00-effabe20ba1f"",
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
                    ""id"": ""8ac80d1d-7b5b-4986-9df3-81a3aae37526"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7fe9590-1179-44ad-8da5-16fb74fbc584"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee685924-a923-4517-889b-bfeefaedde16"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Devices"",
                    ""action"": ""TakeFlashlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2cd9df66-8d47-44d6-af2b-6170167cefcd"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Devices"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99505bd1-9a63-446d-a7cc-60118beece9a"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Devices"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb926eac-276f-4f01-839d-81acc0067cab"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Devices"",
                    ""action"": ""TakeWalkie"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6e83edf-45bb-40c0-ae86-21cc253a5716"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Devices"",
                    ""action"": ""Interract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e42c8eeb-16da-4b33-a060-559a4eb93be5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Devices"",
                    ""action"": ""MouseL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63b1ca32-f227-4773-a3f6-e571e9346731"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Devices"",
                    ""action"": ""MouseDrag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Devices"",
            ""bindingGroup"": ""Devices"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_MouseX = m_Player.FindAction("MouseX", throwIfNotFound: true);
        m_Player_MouseY = m_Player.FindAction("MouseY", throwIfNotFound: true);
        m_Player_TakeFlashlight = m_Player.FindAction("TakeFlashlight", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
        m_Player_TakeWalkie = m_Player.FindAction("TakeWalkie", throwIfNotFound: true);
        m_Player_Interract = m_Player.FindAction("Interract", throwIfNotFound: true);
        m_Player_MouseL = m_Player.FindAction("MouseL", throwIfNotFound: true);
        m_Player_MouseDrag = m_Player.FindAction("MouseDrag", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_MouseX;
    private readonly InputAction m_Player_MouseY;
    private readonly InputAction m_Player_TakeFlashlight;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_TakeWalkie;
    private readonly InputAction m_Player_Interract;
    private readonly InputAction m_Player_MouseL;
    private readonly InputAction m_Player_MouseDrag;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @MouseX => m_Wrapper.m_Player_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Player_MouseY;
        public InputAction @TakeFlashlight => m_Wrapper.m_Player_TakeFlashlight;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @TakeWalkie => m_Wrapper.m_Player_TakeWalkie;
        public InputAction @Interract => m_Wrapper.m_Player_Interract;
        public InputAction @MouseL => m_Wrapper.m_Player_MouseL;
        public InputAction @MouseDrag => m_Wrapper.m_Player_MouseDrag;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @MouseX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseY;
                @TakeFlashlight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeFlashlight;
                @TakeFlashlight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeFlashlight;
                @TakeFlashlight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeFlashlight;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @TakeWalkie.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeWalkie;
                @TakeWalkie.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeWalkie;
                @TakeWalkie.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakeWalkie;
                @Interract.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterract;
                @Interract.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterract;
                @Interract.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInterract;
                @MouseL.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseL;
                @MouseL.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseL;
                @MouseL.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseL;
                @MouseDrag.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseDrag;
                @MouseDrag.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseDrag;
                @MouseDrag.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseDrag;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @TakeFlashlight.started += instance.OnTakeFlashlight;
                @TakeFlashlight.performed += instance.OnTakeFlashlight;
                @TakeFlashlight.canceled += instance.OnTakeFlashlight;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @TakeWalkie.started += instance.OnTakeWalkie;
                @TakeWalkie.performed += instance.OnTakeWalkie;
                @TakeWalkie.canceled += instance.OnTakeWalkie;
                @Interract.started += instance.OnInterract;
                @Interract.performed += instance.OnInterract;
                @Interract.canceled += instance.OnInterract;
                @MouseL.started += instance.OnMouseL;
                @MouseL.performed += instance.OnMouseL;
                @MouseL.canceled += instance.OnMouseL;
                @MouseDrag.started += instance.OnMouseDrag;
                @MouseDrag.performed += instance.OnMouseDrag;
                @MouseDrag.canceled += instance.OnMouseDrag;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    private int m_DevicesSchemeIndex = -1;
    public InputControlScheme DevicesScheme
    {
        get
        {
            if (m_DevicesSchemeIndex == -1) m_DevicesSchemeIndex = asset.FindControlSchemeIndex("Devices");
            return asset.controlSchemes[m_DevicesSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnTakeFlashlight(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnTakeWalkie(InputAction.CallbackContext context);
        void OnInterract(InputAction.CallbackContext context);
        void OnMouseL(InputAction.CallbackContext context);
        void OnMouseDrag(InputAction.CallbackContext context);
    }
}
