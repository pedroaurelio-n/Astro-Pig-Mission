// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerGameplay"",
            ""id"": ""18e7e913-8ea1-4737-8cb6-5f181fcc5227"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0c5e8a75-45db-43e2-8c3a-06b965326625"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""PassThrough"",
                    ""id"": ""95d7a611-8083-4bab-8a02-622336caf718"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2a43e472-a17c-430b-92ab-b38347dde315"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8980e3f9-0cd1-4c2c-80a2-8b87351dbf16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""PassThrough"",
                    ""id"": ""82bc8158-643d-4d88-9e21-d11037af4228"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1ea925b5-3b56-4ceb-b6a9-a7806e2f74ca"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""148aacf8-373f-47d1-9c2b-6fb27666ddac"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d856710-244f-4d53-99ac-49e484b44367"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""926a1697-eb3a-467a-9610-86093fcce7ac"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4d4261e-50f7-45f2-be53-b564fc9d9616"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c9c7eee-43fb-4a01-a14b-d71e13ad82b1"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""a1f79b19-586c-4a78-b1d5-301b86725234"",
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
                    ""id"": ""142201ec-5abd-49ba-8a1f-fe4398dabfc8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ed85942c-263c-4103-b1ed-15c27c3bae8a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9cb17596-5e75-4067-adc3-df6f54058eca"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""19ba4447-1503-4872-9c4c-dcbdfb432c6f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AnalogStick"",
                    ""id"": ""c9bbef70-3744-43c3-a6df-0eb6d1cc88b2"",
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
                    ""id"": ""7717acde-e58f-4c61-a4d0-502a6abde70c"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""51174f7f-8f84-4d12-928c-558bbf09b782"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c750610b-c0cd-4aa8-a54c-d36e5e59b1da"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""848b63bc-b6db-447b-9b80-9c40daea9faf"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""88459e9a-2738-4e8c-bf5a-975bf0dfeec4"",
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
                    ""id"": ""b1310da7-2bd6-43e8-b39a-ce26e6a48988"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a39af423-d690-4f8b-931d-6e80184e97e8"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""67474134-135c-4292-b973-2a8c6f7be6db"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a9e1ef9d-aa48-46da-bb48-fb9a5af33f39"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f348e234-d993-49fa-b11f-0299e2841b32"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerUI"",
            ""id"": ""026973cb-1f97-4cd1-ad3b-efee94194abc"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""12636f87-0781-48b9-b0d6-d0ef4a6308fc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""4cc5f04f-a892-4bdf-a818-3fe6d1fda69e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""2c33b652-20e4-4c12-87a0-c71ca4e57915"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""53dcc112-adea-4451-b95d-8a27cfa53d1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""61eee81b-545b-4643-a343-f04708db17c2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c21777a8-e2e7-4255-b40d-41cf3eb900cb"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""f93112e3-9502-4e16-aa80-9a71fbf31512"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e470c73b-e011-4272-aaf1-7e5c11e182b7"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fd3f253c-02bf-4a8b-8cdd-15f040945b6d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""71ad1e38-7ea3-41cf-ae1c-909a64e14657"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6ea19d5e-0f2a-4d82-8fbc-3f9e4eaecfb1"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""730a9174-db71-40c7-b550-2412c7089919"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2f6affd6-2fcb-45dd-95af-5ddc44983af6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bb39a4c7-f03a-480f-a69f-1f9bef107007"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""525f57bb-7c6a-488f-9bfd-a7cbc035fcff"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""13aa169b-b68f-4f1a-9c2e-da60a2951a21"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4de5ffb9-096f-441d-9769-c8ff7c5d2c02"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ba3f046-1204-4876-b89f-2c203bac13d7"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52b56f0f-775b-4cf2-be62-0f32b3583c87"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4811e0d-4140-403d-a223-fba36ec6510b"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a770153-dca1-4afd-8d45-26790ece9c19"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25f2ccf6-7087-4e7f-b3cf-c1c0e8aeb48a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerGameplay
        m_PlayerGameplay = asset.FindActionMap("PlayerGameplay", throwIfNotFound: true);
        m_PlayerGameplay_Movement = m_PlayerGameplay.FindAction("Movement", throwIfNotFound: true);
        m_PlayerGameplay_Fire = m_PlayerGameplay.FindAction("Fire", throwIfNotFound: true);
        m_PlayerGameplay_Interaction = m_PlayerGameplay.FindAction("Interaction", throwIfNotFound: true);
        m_PlayerGameplay_Restart = m_PlayerGameplay.FindAction("Restart", throwIfNotFound: true);
        m_PlayerGameplay_Pause = m_PlayerGameplay.FindAction("Pause", throwIfNotFound: true);
        // PlayerUI
        m_PlayerUI = asset.FindActionMap("PlayerUI", throwIfNotFound: true);
        m_PlayerUI_Move = m_PlayerUI.FindAction("Move", throwIfNotFound: true);
        m_PlayerUI_Submit = m_PlayerUI.FindAction("Submit", throwIfNotFound: true);
        m_PlayerUI_Cancel = m_PlayerUI.FindAction("Cancel", throwIfNotFound: true);
        m_PlayerUI_Click = m_PlayerUI.FindAction("Click", throwIfNotFound: true);
        m_PlayerUI_Point = m_PlayerUI.FindAction("Point", throwIfNotFound: true);
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

    // PlayerGameplay
    private readonly InputActionMap m_PlayerGameplay;
    private IPlayerGameplayActions m_PlayerGameplayActionsCallbackInterface;
    private readonly InputAction m_PlayerGameplay_Movement;
    private readonly InputAction m_PlayerGameplay_Fire;
    private readonly InputAction m_PlayerGameplay_Interaction;
    private readonly InputAction m_PlayerGameplay_Restart;
    private readonly InputAction m_PlayerGameplay_Pause;
    public struct PlayerGameplayActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerGameplayActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerGameplay_Movement;
        public InputAction @Fire => m_Wrapper.m_PlayerGameplay_Fire;
        public InputAction @Interaction => m_Wrapper.m_PlayerGameplay_Interaction;
        public InputAction @Restart => m_Wrapper.m_PlayerGameplay_Restart;
        public InputAction @Pause => m_Wrapper.m_PlayerGameplay_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PlayerGameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerGameplayActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerGameplayActions instance)
        {
            if (m_Wrapper.m_PlayerGameplayActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnMovement;
                @Fire.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnFire;
                @Interaction.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnInteraction;
                @Restart.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnRestart;
                @Pause.started -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerGameplayActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerGameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerGameplayActions @PlayerGameplay => new PlayerGameplayActions(this);

    // PlayerUI
    private readonly InputActionMap m_PlayerUI;
    private IPlayerUIActions m_PlayerUIActionsCallbackInterface;
    private readonly InputAction m_PlayerUI_Move;
    private readonly InputAction m_PlayerUI_Submit;
    private readonly InputAction m_PlayerUI_Cancel;
    private readonly InputAction m_PlayerUI_Click;
    private readonly InputAction m_PlayerUI_Point;
    public struct PlayerUIActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerUIActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerUI_Move;
        public InputAction @Submit => m_Wrapper.m_PlayerUI_Submit;
        public InputAction @Cancel => m_Wrapper.m_PlayerUI_Cancel;
        public InputAction @Click => m_Wrapper.m_PlayerUI_Click;
        public InputAction @Point => m_Wrapper.m_PlayerUI_Point;
        public InputActionMap Get() { return m_Wrapper.m_PlayerUI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerUIActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerUIActions instance)
        {
            if (m_Wrapper.m_PlayerUIActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnMove;
                @Submit.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnCancel;
                @Click.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnClick;
                @Point.started -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_PlayerUIActionsCallbackInterface.OnPoint;
            }
            m_Wrapper.m_PlayerUIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
            }
        }
    }
    public PlayerUIActions @PlayerUI => new PlayerUIActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IPlayerUIActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
    }
}
