
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""06e2e044-dc97-441e-9ea1-bd15e9b04f47"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b4cfa15f-773b-4fc4-be17-846b191de515"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""e23c0670-49bf-45d7-9046-fca07e0c6421"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b5dedce7-6c9a-475e-b8ad-e30e520e9fe7"",
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
                    ""id"": ""cfaec022-e001-4153-a220-b9adc9fe35c2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c2efcad3-45dc-4566-87f7-7f62e67d76ba"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""934c857e-b3de-445e-8338-af8cf4d8a0e6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""60ea2f80-2172-4237-8768-89aee8446e0b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dd27a674-bf8c-411e-a845-8a8d6b42f89d"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""FightSystem"",
            ""id"": ""0237563d-1ce5-4a31-bea7-b6da48c3e675"",
            ""actions"": [
                {
                    ""name"": ""SwordAttack"",
                    ""type"": ""Button"",
                    ""id"": ""34a9957f-61fe-4eb0-9bcb-5d49f2169186"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5ec7206c-36c9-40dc-8a62-dcfaf8750403"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwordAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""49667eae-7749-4e2f-9509-f0d50c1e22bb"",
            ""actions"": [
                {
                    ""name"": ""OpenMenu"",
                    ""type"": ""Button"",
                    ""id"": ""d7e33cab-7974-4845-bc99-69454f8dccb5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CloseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""4047386f-9dae-4e13-a99b-ec180bb3a6a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OpenInventory"",
                    ""type"": ""Button"",
                    ""id"": ""c7ab24c8-7eb7-4b92-a42d-b724e6e612ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CloseInventory"",
                    ""type"": ""Button"",
                    ""id"": ""92d16392-620f-4240-b565-975f0d5b915f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cd2b71ce-a491-447c-9820-5841a9ab63f6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3465d017-9f18-456a-b8b8-1eed21cd9388"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7ddba14-851e-494e-95aa-776fea906e5b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac2af060-93d6-41da-98cf-221c905d1e58"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        m_Movement_Run = m_Movement.FindAction("Run", throwIfNotFound: true);
        // FightSystem
        m_FightSystem = asset.FindActionMap("FightSystem", throwIfNotFound: true);
        m_FightSystem_SwordAttack = m_FightSystem.FindAction("SwordAttack", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_OpenMenu = m_UI.FindAction("OpenMenu", throwIfNotFound: true);
        m_UI_CloseMenu = m_UI.FindAction("CloseMenu", throwIfNotFound: true);
        m_UI_OpenInventory = m_UI.FindAction("OpenInventory", throwIfNotFound: true);
        m_UI_CloseInventory = m_UI.FindAction("CloseInventory", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_Move;
    private readonly InputAction m_Movement_Run;
    public struct MovementActions
    {
        private @PlayerControls m_Wrapper;
        public MovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputAction @Run => m_Wrapper.m_Movement_Run;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // FightSystem
    private readonly InputActionMap m_FightSystem;
    private List<IFightSystemActions> m_FightSystemActionsCallbackInterfaces = new List<IFightSystemActions>();
    private readonly InputAction m_FightSystem_SwordAttack;
    public struct FightSystemActions
    {
        private @PlayerControls m_Wrapper;
        public FightSystemActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwordAttack => m_Wrapper.m_FightSystem_SwordAttack;
        public InputActionMap Get() { return m_Wrapper.m_FightSystem; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FightSystemActions set) { return set.Get(); }
        public void AddCallbacks(IFightSystemActions instance)
        {
            if (instance == null || m_Wrapper.m_FightSystemActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_FightSystemActionsCallbackInterfaces.Add(instance);
            @SwordAttack.started += instance.OnSwordAttack;
            @SwordAttack.performed += instance.OnSwordAttack;
            @SwordAttack.canceled += instance.OnSwordAttack;
        }

        private void UnregisterCallbacks(IFightSystemActions instance)
        {
            @SwordAttack.started -= instance.OnSwordAttack;
            @SwordAttack.performed -= instance.OnSwordAttack;
            @SwordAttack.canceled -= instance.OnSwordAttack;
        }

        public void RemoveCallbacks(IFightSystemActions instance)
        {
            if (m_Wrapper.m_FightSystemActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IFightSystemActions instance)
        {
            foreach (var item in m_Wrapper.m_FightSystemActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_FightSystemActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public FightSystemActions @FightSystem => new FightSystemActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_OpenMenu;
    private readonly InputAction m_UI_CloseMenu;
    private readonly InputAction m_UI_OpenInventory;
    private readonly InputAction m_UI_CloseInventory;
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenMenu => m_Wrapper.m_UI_OpenMenu;
        public InputAction @CloseMenu => m_Wrapper.m_UI_CloseMenu;
        public InputAction @OpenInventory => m_Wrapper.m_UI_OpenInventory;
        public InputAction @CloseInventory => m_Wrapper.m_UI_CloseInventory;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @OpenMenu.started += instance.OnOpenMenu;
            @OpenMenu.performed += instance.OnOpenMenu;
            @OpenMenu.canceled += instance.OnOpenMenu;
            @CloseMenu.started += instance.OnCloseMenu;
            @CloseMenu.performed += instance.OnCloseMenu;
            @CloseMenu.canceled += instance.OnCloseMenu;
            @OpenInventory.started += instance.OnOpenInventory;
            @OpenInventory.performed += instance.OnOpenInventory;
            @OpenInventory.canceled += instance.OnOpenInventory;
            @CloseInventory.started += instance.OnCloseInventory;
            @CloseInventory.performed += instance.OnCloseInventory;
            @CloseInventory.canceled += instance.OnCloseInventory;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @OpenMenu.started -= instance.OnOpenMenu;
            @OpenMenu.performed -= instance.OnOpenMenu;
            @OpenMenu.canceled -= instance.OnOpenMenu;
            @CloseMenu.started -= instance.OnCloseMenu;
            @CloseMenu.performed -= instance.OnCloseMenu;
            @CloseMenu.canceled -= instance.OnCloseMenu;
            @OpenInventory.started -= instance.OnOpenInventory;
            @OpenInventory.performed -= instance.OnOpenInventory;
            @OpenInventory.canceled -= instance.OnOpenInventory;
            @CloseInventory.started -= instance.OnCloseInventory;
            @CloseInventory.performed -= instance.OnCloseInventory;
            @CloseInventory.canceled -= instance.OnCloseInventory;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
    public interface IFightSystemActions
    {
        void OnSwordAttack(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnOpenMenu(InputAction.CallbackContext context);
        void OnCloseMenu(InputAction.CallbackContext context);
        void OnOpenInventory(InputAction.CallbackContext context);
        void OnCloseInventory(InputAction.CallbackContext context);
    }
}
