# 🧩 EasyCS – Entity-Data Framework for Unity

![Alt Text](https://i.imgur.com/ZKoOJxK.png)

**EasyCS** is a modern, scriptable, and **SUPER** editor-friendly Entity-Component-System (ECS) framework designed specifically for Unity, where "S"(stand for System) in ECS is completely optional.

It bridges the gap between traditional Unity OOP workflows and ECS — without sacrificing usability or flexibility.

The main idea is that you don't need to shift your mind-set from Unity Component-OOP appoach to ECS, while still benefiting from improved Entity-Data workflow!

## 📚 Table of Contents

- [🧩 EasyCS – Entity-Data Framework for Unity](#-easycs--entity-data-framework-for-unity)
- [🚀 Why EasyCS?](#-why-easycs)
- [🌟 Features at a Glance](#-features-at-a-glance)
- [🔍 Comparison Table](#-framework-comparison-table)
- [📦 Dependencies](#-dependencies)
- [⚙️ Setup](#️-setup)
  - [🔧 Setup with VContainer (Optional)](#optional-️-setup-with-vcontainer)
  - [🧪 Setup with Zenject (Optional)](#optional-️-setup-with-zenject)
- [📚 Examples](#-examples)
- [💬 Join the Community](#-join-the-community)
- [📂 Getting Started](#-getting-started)
- [🐣 Basics](#basics)
  - [💥 Instantiate / Destroy](#instantiate-object)
  - [🛠 ScriptableObjects Creator](#scriptableobjects-creator)
  - [📦 Data Types](#data-types)
    - [🧱 IEntityData](#ientitydata)
    - [🧊 ActorData](#actordata)
    - [🔗 ActorDataShared](#actordatashared)
  - [🧠 Behavior Types](#behavior-types)
    - [🧬 EasyCSBehavior](#easycsbehavior)
    - [🎭 ActorBehavior](#actorbehavior)
    - [🛰 EntityBehavior](#entitybehavior)
  - [🔁 LifeTimeCycle Callbacks](#lifetimecycle-callbacks)
  - [📡 Entity Signals](#entity-signals)
- [🧭 Advanced](#advanced)
  - [📄 EntityPredefinedScriptableObject](#entitypredefinedscriptableobject)
  - [📌 EntityProvider](#entityprovider)
  - [🏗️ EntityFactory](#entityfactory)
- [🤝 Contributing](#-contributing)
- [💖 Support the Developer](#-support-the-developer)
- [📝 License](#-license)

---

## 🚀 Why EasyCS?
- 🔀 **Split Behavior and Data layers** – Provides a clean separation between logic (behaviors) and state (data), making systems more modular, testable, and reusable.
- 🏗️ **Entity and Unity Layers** – Organize your logic and data either on the Unity side or within Entity, depending on your needs.
- ✅ **Familiar Workflow** – Work with Unity GameObjects, Prefabs and ScriptableObjects even better than before!
- 🧠 **Prefab-based Entity Construction** – Design Entity as prefabs and serialize in ScriptableObjects
- 📦 **ScriptableObjects Data** – All data can be automatically packed in ScriptableObjects when you need it. Forget about writing ScriptableObjects like in old days!
- 💡 **Zero-Delay ECS** – No deferred execution; all changes apply instantly
- 🔧 **Editor-first** – Designed with custom inspector tooling and editor extensions
- 🧙 **Odin-Compatibility** - Compatible with OdinInspector & Odin-Validator
- 🔗 **Supports Cross-scene & Cross-session References** – Maintain links between entities and GameObjects across the scenes!
- 🧱 **Framework-Agnostic** – Drop-in ready with Zenject or VContainer support **(Optional)**

---

## 📦 Features at a Glance

| Feature                          | Description                                      |
|----------------------------------|--------------------------------------------------|
| 🛠 Entity Authoring              | Build entity hierarchies using Prefabs or SOs    |
| 🧩 Component Injection           | Auto-attach required dependencies                |
| 🔍 Editor Dependency Checks      | Let's you know if you forget to add components
| 💾 ScriptableObject Factories   | Edit reusable data blocks in the inspector       |
| 🧠 Behavior Providers           | Modular runtime behaviors with injection         |
| 📂 Auto-generated Source        | Providers and factories created via reflection   |
| ⚙️ Framework Integrations       | Built-in support for Zenject, VContainer         |

## 🔍 Framework Comparison Table

| Feature / Capability                        | Classic Unity            | Zenject / VContainer DI                     | Classical ECS               | 🧩 **EasyCS**                         |
|--------------------------------------------|---------------------------|---------------------------------------------|-----------------------------|--------------------------------------|
| ✅ **ScriptableObject Integration**         | ❌ Manual, boilerplate     | 🟡 Manual or per-pattern                     | ❌ Not used                  | ✅ Native + Automated                |
| 🧱 **Component Modularity**                 | 🟡 MonoBehavior composition | 🟡 Service-level modularity only             | ✅ System-defined archetypes | ✅ Behavior + Data Layers           |
| 🔄 **Instantiate / Destroy Entities**       | 🟡 GameObject.Destroy      | 🟡 Unity-style destruction                   | ✅ Built-in, loop-friendly   | ✅ Entity-aware creation/destruction|
| 💾 **Save System Integration**              | ❌ Requires boilerplate     | 🟡 DI-friendly but needs logic               | 🟡 Loop-ready, verbose       | ✅ Loopable + serializable data     |
| 🧩 **Entity Construction**                  | ❌ Manual Mono setup        | 🟡 Scene installers + custom prefabs         | ✅ Data-defined archetypes   | ✅ Prefab + Scriptable Entity setup |
| 🧠 **MonoBehaviour Reuse**                  | ✅ Built-in                 | 🟡 Wrapped in services                       | 🟡 Requires refactoring      | ✅ Retains Unity-style reuse        |
| 🧩 **Local Data Injection**                 | ❌ Manual references        | 🟡 Needs custom installers                   | ❌ Not designed for it       | ✅ Declarative and automatic       |
| 🏁 **Entry Point (Lifecycle Bootstrap)**    | ❌ None                     | ✅ Custom installers                         | ✅ System-based              | ✅ EasyCSInstaller                  |
| 🔁 **Loop-Ready Data Access**               | ❌ Not supported natively   | 🟡 Partial (registered only)                | ✅ Native                    | ✅ Native per Entity access         |
| ⚡ **Conversion from Existing Code**        | —                          | 🟡 Needs wrapping in services                | ❌ Full refactor required    | ✅ Easy MonoBehaviour conversion    |
| 💡 **Learning Curve**                       | ✅ Familiar                 | 🟡 Moderate (DI concepts)                    | ❌ High (ECS paradigm shift) | ✅ Low, Unity-like feel             |
| 🔌 **Compatible with DI Frameworks**        | 🟡 With adapters            | ✅ Native                                    | ❌ Not applicable            | ✅ Optional & Compatible            |
| ⚡ **Logic Reactivity**                    | ✅ Native                    | ✅ Native                                   | 🟡 Frame-delayed             | ✅ Native                           |
| 🧪 **Prototype Friendliness**              | ✅ Easy but needs refactor  | 🟡 Needs additional setup                    | ❌ Not friendly              | ✅ Near Native                    |
| 🧰 **Editor-Friendliness**                 | 🟡 Familiar but limited     | 🟡 Same as Unity                             | ❌ Poor integration          | ✅ Enhanced with tools & Validation |
| 📈 **Scalability**                        | ❌ Requires custom solutions | 🟡 Improves scaling, not ideal for per-object data | ✅ Built for large-scale systems | ✅ Potentially scalable |

---

## 📦 Dependencies

| Package            | Purpose                    | Optional |
|--------------------|----------------------------|----------|
| Unity 2021+        | Minimum version supported  | ❌        |
| com.unity.2d.animation | Required for editor-hooks  | ❌        |
| Tri Inspector Plus | Required for editor        | ❌ |
| Zenject            | DI Framework support       | ✅        |
| VContainer         | DI Framework support       | ✅        |
| Odin Inspector     | Enhanced inspector UI      | ✅        |

---

## ⚙️ Setup

1. Go to releases and download Unity package:

https://github.com/Watcher3056/EasyCS-Submodule/releases

2. Import `.unitypackage` to your project

3. Attach `EasyCSInstaller` component to GameObject on scene

---

### (Optional) ⚙️ Setup with VContainer
5. Attach `LifeTimeScopeWithInstallers` component on the same GameObject as before
6. Drag-n-Drop `EasyCSInstaller` into `Installers` list on `LifeTimeScopeWithInstallers`

---

### (Optional) ⚙️ Setup with Zenject
5. Make sure to attach `EasyCSInstaller` component on the GameObject with `SceneContext`
6. Drag-n-Drop `EasyCSInstaller` into `Mono Installers` list on `SceneContext`

---


## 📚 Examples

Check:
`Assets/EasyCS/EasyCS-Samples/`

---

## 💬 Join the Community

Have questions, feedback, or ideas? Join our Discord server to chat with other developers, share your projects, or get help from the EasyCS community!

👉 [Join our Discord](https://discord.gg/PTdEpJgQ)

## 📂 Getting Started

### 1. Create an EntityData Component
```csharp
using EasyCS;

[Serializable]
public class EntityDataHealthMax : EntityDataBase<float> {}
```

### 2. Create an ActorBehaviorHealth
```csharp
using EasyCS;

public class ActorBehaviorHealth : ActorBehavior
{

}
```

### 3. Bind components

```csharp
using EasyCS;

public class ActorBehaviorHealth : ActorBehavior
{
    [Bind]
    private EntityDataHealthMax _dataHealthMax;
}
```

### 4. Override callbacks
```csharp
using EasyCS;
using UnityEngine;

public class ActorBehaviorHealth : ActorBehavior
{
    [Bind]
    private EntityDataHealthMax _dataHealthMax;

    protected override void HandleAwake()
    {
        base.HandleAwake();

        Debug.Log(_dataHealthMax.Value);
    }
}
```

**Note:** Specifically in ActorBehavior you can override next callbacks:
- HandleAwake
- HandleDestroy
- HandleEntityAttached
- HandleEntityDetached
- HandleEnable
- HandleDisable
**Note:** For other callbacks implement IStart, IUpdate, IFixedUpdate, ILateUpdate interfaces

Generate providers:

![Alt text](https://i.imgur.com/crNzuwl.png)

### 5. Attach components to GameObject
- `Actor`
- `ActorBehaviorHealth`
- `EntityDataProviderHealthMax`


![Alt text](https://i.imgur.com/XWFnv72.png)

### 6. Done!
![Alt text](https://i.imgur.com/5bNQFep.png)
   

---

# Basics

## Instantiate Object

Simply use:

`EasyCsContainer.Instantiate(prefab)` 

OR

`EasyCsContainer.InstantiateWithEntity(prefab)` to assign random `Entity` automatically to `Actor`

---

## Destroy Object

Simply use:

`GameObject.Destroy(gameObject)` every `Actor` will be destroyed with `Entity`

OR

`Actor.DestroyGameObjectWithoutEntities()` 
 every `Actor` will be destroyed but `Entity` will remain alive

---

## ScriptableObjects Creator

Powerful tool that allows you to search and create **ANY** ScriptableObjects using custom EditorWindow

![Alt Text](https://i.imgur.com/7TgJTLk.gif)

---

## Data Types

### IEntityData

Features:

- Stores directly on `Entity`.
- Can be created using `EntityDataFactory` asset
- Can Exist without `Actor`(GameObject).

General usage case:
- Runtime data(Current Speed, Current Health)
- Non-`UnityEngine.Object` configurations(Max Speed, Max Health, Name)

Examples:

```csharp
using EasyCS;

[Serializable]
public EntityDataHealth : EntityDataBase<float> {}
```
Easy shortcut to wrap single piece of data

```csharp
[Serializable]
public class EntityDataAttack : EntityDataCustomBase
{
    public float attackRange;
    public float attackSpeed;
    public float delayToNextAttack;

    public override object Clone()
    {
        return new EntityDataAttack
        {
            attackRange = this.attackRange
            attackSpeed = this.attackSpeed,
            delayToNextAttack = this.delayToNextAttack,
        };
    }
}
```

Use it to wrap several variables

---

### ActorData

Features:

- Stores directly on `Actor`

General usage case:
- View-specific configurations(timings, delays, etc.)
- Store links to objects in hierarchy `GameObject`, `Transform`, `Component`, `Monobehaviours`.

Examples:

```csharp
using TriInspector;
using UnityEngine;

public class ActorDataAnimator : ActorData
{
    [field: SerializeField, Required]
    public Animator Animator { get; private set; }
}
```

### ActorDataShared

Features:
- Stores directly on `Actor`
- Single instance shared between multiple `Actor`'s

General usage case:
- For static data
- Store links to assets `Prefab`, `ScriptableObject`, `Sprite`, etc.

```csharp
using System;
using TriInspector;
using UnityEngine;

[Serializable]
public class ActorDataSharedProjectilePrefab : ActorDataSharedBase
{
    [field: SerializeField, Required]
    public PrefabRootData Prefab { get; private set; }
    [field: SerializeField]
    public float ProjectileSpeed { get; private set; }
}

```

## Behavior Types

### EasyCSBehavior

Replacement for default `Monobehaviours`

Features:
- Initialize and updates from main entry-point
- Has `EasyCsContainer` property to accessing EasyCS functionality

General usage case:
- UI components
- Level Controller, etc.
- Other components that don't require `Entity` or `Actor`

Examples:

```csharp
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : EasyCSBehavior
{
    [SerializeField] 
    private Image _fillImage;
    [SerializeField] 
    private float _maxWidth = 200f;

    public void SetProgress(float value)
    {
        // Progress bar logic
    }
}
```

---

### ActorBehavior

Features:
- Everything from `EasyCSBehavior`
- Inject required components using `[Bind]`
- Stores directly on `Actor`

General usage case:
- Implementing behaviors for your `Actor` on scene(Move Behavior, Attack Behavior, AI Controller, Custom Animations Controller, etc.)
- Listening to `Entity` events
- Sending `Entity` events

Examples

```csharp
using EasyCS.EventSystem;
using UnityEngine;

public class ActorBehaviorMove : ActorBehavior, IFixedUpdate, IEventListener<EventDied>
{
    [Bind]
    private EntityDataMove _dataMove;
    [Bind]
    private ActorDataRigidbody _dataRigidbody;


    public void OnFixedUpdate(float deltaTime)
    {
        Vector3 nextPosition = Actor.transform.position + _dataMove.Value * deltaTime;

        _dataRigidbody.Rigidbody.MovePosition(nextPosition);
    }

    public void HandleEvent(in EventContext<EventDied> ctx)
    {
        enabled = false;
    }
}

```

### EntityBehavior

Features:
- Inject required components using `[Bind]`
- Stores directly on `Entity`
- Has Life Time Callbacks(OnStart, OnAwake, OnUpdate etc.)

General usage case:
- Implementing behaviors for `Entity` without `GameObject` (Inventory Items, Inventory System, etc.)
- Listening to `Entity` events
- Sending `Entity` events

Examples

```csharp
using System;
using EasyCS.EventSystem;

[Serializable]
public class EntityBehaviorHealth : EntityBehaviorBase, IAwake, IEventListener<EventDealDamage>
{
    [Bind]
    private EntityDataHealth _health;
    [Bind]
    private EntityDataHealthMax _healthMax;

    public void OnAwake()
    {
        ResetToMax();
    }

    public void HandleEvent(in EventContext<EventDealDamage> ctx)
    {
        SetHealth(_health.Value - ctx.Event.damage);
    }

    public void SetHealth(float health)
    {
        bool isAliveBefore = IsAlive;
        float prevHealth = _health.Value;

        _health.Value = health;

        EventSystem.Raise(new EventHealthChanged(prevHealth, _health.Value), Entity);
    }
}
```

## LifeTimeCycle Callbacks

EasyCS provides you several of the well known Unity callbacks that perfectly integrated.

Add them by implementing next callbacks:

- `IHasContainer` - allows you to inject EasyCSContainer in your classes. Works even for default Monobehaviors
- `IStart`
- `IAwake`
- `IUpdate`
- `IFixedUpdate`
- `ILateUpdate`
- `IDispose` - Destroy alternative for `EntityComponent`

Limitation: 
- Most of the callbacks works only on `EasyCSBehavior`, `ActorComponent`, `EntityComponent`

---


## Entity Signals

Allows you to listen and sends events to `Entity`

### Receive signal


Implement `IEventListener<T>` interface on any of the next behaviors:
- ActorBehavior
- EntityBehavior

Subscription to events will be done automatically

You can also listen to `Entity` events inside `EasyCSBehavior`, but for this you need to subscribe to specific `Entity` manually:

```csharp

using EasyCS.EventSystem;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : EasyCSBehavior, IEventListener<EventHealthChanged>
{
    [SerializeField] 
    private Image _fillImage;
    [SerializeField] 
    private float _maxWidth = 200f;

    private Actor _actor;

    public void SetActor(Actor actor)
    {
        _actor = actor;
        EventSystem.TrySubscribe(this, actor.Entity);
    }

    public void HandleEvent(in EventContext<EventHealthChanged> ctx)
    {
        EntityDataHealth dataHealth = ctx.Entity.GetComponent<EntityDataHealth>();
        EntityDataHealthMax dataHealthMax = ctx.Entity.GetComponent<EntityDataHealthMax>();

        SetProgress(dataHealth.Value / dataHealthMax.Value);
    }

    public void SetProgress(float value)
    {
        value = Mathf.Clamp01(value);
        RectTransform rt = _fillImage.rectTransform;
        rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, _maxWidth * value);
    }
}

```

### Sends Signals

#### Local events

This events always associated with concrete `Entity`

Examples:
```csharp
EventSystem.TrySubscribe(this, Entity);
Entity.RaiseEvent(new EventTryAttack());
```

OR

```csharp
EventSystem.TrySubscribe(this, Entity);
EventSystem.Raise(new EventTryAttack(), Entity);
```

---

#### Global events

This events associated with `Entity.Empty` so can be listen and invoked from anywhere

Examples:

```csharp
EventSystem.SubscribeGlobal<EventDied>(this);
EventSystem.RaiseGlobal(new EventTryAttack());
```

---

# Advanced

## EntityPredefinedScriptableObject

![Alt Text](https://i.imgur.com/CEwGBtq.png)

- Allows you to serialize `Entity.ID` and restore it access it later
- Provides storage for `Entity.ID` in asset, allowing cross-scene and cross-session references
- Static and never changes between builds

## EntityProvider

![Alt Text](https://i.imgur.com/2oxRaVR.png)

Entity wrapper for objects on scene.
- Automatically added to any `Actor` on scene
- Can be added manually anywhere(for example in prefabs)
- Preserve same `Entity.ID` between sessions and builds
- Works with `EntityPredefinedScriptableObject`

---

## EntityFactory

Provides a way to build and serialize `Entity` and hierarchy of several `Entity` in a single ScriptableObject

![Alt Text](https://i.imgur.com/CISzOre.png)

- Click `Edit Entity Factory` button to open Prefab Edit Mode workflow.

- It allows you to build `Entity` in the same way you build them on `Actor` before, by adding `EntityDataProvider` and `EntityBehaviorProvider` components on GameObjects.

- Each GameObject represents separated instance of `Entity`

- Exit Prefab Edit Mode to automatically save the `Entity` to `EntityFactory` asset

Limitation:
- You can't add `ActorComponent` during that mode, because you desiging Entity-layer data & logic in the `EntityFactory`

---

## 🤝 Contributing

PRs welcome! Open an issue or suggestion for feedback, bug reports, or questions.  
This project is intended to grow with real-world game developer feedback.

---

## 💖 Support the Developer

If you enjoy using **EasyCS** or find it useful in your project, consider supporting its development:

- 🌟 [Give the project a star on GitHub](https://github.com/Watcher3056/EasyCS) — it helps others discover it!
- ☕ [Buy me a coffee](https://buymeacoffee.com/maxtokadevc) — every contribution fuels future improvements.

Your support keeps the framework alive and evolving. Thank you! 🙌

## 📝 License

[MIT](LICENSE)

---

Made with ❤️ for Unity developers who need structure *and* freedom.
