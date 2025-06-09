# 🧩 EasyCS: Data-Driven Entity & Actor-Component Framework for Unity

![Alt Text](https://i.imgur.com/ZKoOJxK.png)

EasyCS is an **easy-to-use and flexible** framework for Unity designed to empower developers with a flexible and performant approach to structuring game logic. It bridges the gap between traditional Object-Orientated Programming (OOP) in Unity and the benefits of data-oriented design, **without forcing a complete paradigm shift or complex migrations.**  
At its core, EasyCS allows you to:

* **Decouple data from logic:** Define your game data (e.g., character stats, inventory items) as plain C\# objects (**Entities**) independent of Unity's MonoBehaviour lifecycle.  
* **Organize logic cleanly:** Implement game behaviors (**Systems**) that operate on this decoupled data, promoting modularity and testability. **Crucially, Systems are an optional feature in EasyCS; you decide if and when to use them.**  
* **Integrate seamlessly with Unity:** Connect your data-driven logic back to your GameObjects and MonoBehaviours, providing granular control without sacrificing Unity's intuitive editor workflow.  
* **Maximize ScriptableObject utility:** EasyCS provides robust tools to work with ScriptableObjects, significantly reducing boilerplate and enhancing their utility for data management.

Unlike traditional ECS solutions, EasyCS offers a **gradual adoption path**. You can leverage its powerful features where they make sense for your project, **without the high entry barrier or full migration costs** often associated with other frameworks. This makes EasyCS an ideal choice for both new projects and for **integrating into existing Unity codebases, even mid-development.**

## 📚 Table of Contents

- [🧩 EasyCS – Data-Driven Entity & Actor-Component Framework for Unity](#-easycs-data-driven-entity--actor-component-framework-for-unity)
- [🚀 Why EasyCS?](#-why-easycs-solving-common-unity-development-challenges)
- [🌟 Features at a Glance](#-features-at-a-glance)
- [🔍 Comparison Table](#-framework-comparison-table)
- [📦 Dependencies](#-dependencies)
- [❔ FAQ](#frequently-asked-questions-faq)
  - [Is EasyCS just another ECS framework?](#is-easycs-just-another-ecs-framework)
  - [Is EasyCS as complex and slow to develop with as other ECS frameworks?](#is-easycs-as-complex-and-slow-to-develop-with-as-other-ecs-frameworks)
  - [EasyCS vs. other ECS (like Unity DOTS)?](#easycs-vs-other-ecs-like-unity-dots)
  - [I'm using DI (Zenject, VContainer) do I need EasyCS?](#im-using-di-zenject-vcontainer-do-i-need-easycs)
  - [Is EasyCS suitable for Junior, Mid, or Senior developers?](#is-easycs-suitable-for-junior-mid-or-senior-developers)
  - [What kind of games can be made with EasyCS?](#what-kind-of-games-can-be-made-with-easycs)
  - [What kind of games are *not* ideal for EasyCS?](#what-kind-of-games-are-not-ideal-for-easycs)
  - [Do I need to update all MonoBehaviours to EasyCS?](#do-i-need-to-update-all-monobehaviours-to-easycs)
  - [Can Entity & Data exist without GameObjects?](#can-entities-and-data-exist-independently-of-unity-gameobjects)
  - [How to migrate my MonoBehaviours to EasyCS?](#how-to-migrate-my-monobehaviours-to-easycs)
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
  - [🏗️ EntityTemplateAsset](#entitytemplateasset)
  - [📄 EntityPredefinedScriptableObject](#entitypredefinedscriptableobject)
  - [📌 EntityProvider](#entityprovider)
  - [🏗️ EntityFactory](#entityfactory)
- [🤝 Contributing](#-contributing)
- [💖 Support the Developer](#-support-the-developer)
- [📝 License](#-license)

---

## 🚀 Why EasyCS? Solving Common Unity Development Challenges

Many Unity developers, especially those working on **simple to mid-core projects**, face similar hurdles when building games or considering alternative architectures. EasyCS was created to address these common challenges directly and offer a more accessible pathway to improved architecture:

* **Painless Integration & Gradual Adoption:** Integrating a full ECS framework mid-project can be a daunting, risky, and sometimes impractical task, especially for teams unfamiliar with ECS. EasyCS is built for **simple integration into any project, at any stage**. You don't need to refactor everything; apply its principles incrementally where they can provide the most benefit. This flexibility makes it ideal for **fast-paced prototyping** and for teams looking to improve their codebase without a massive overhaul.  
* **Lower Entry Barrier & Familiar Workflow:** Traditional ECS often presents a steep learning curve and demands a significant shift in thinking. EasyCS lets you **continue working with MonoBehaviours as you're used to**, while providing tools to introduce data-oriented principles when beneficial. It's designed as a **framework for beginners to ECS**, offering a gentler introduction without overwhelming complexity.  
* **Automated Data Management with ScriptableObjects:** Unity's ScriptableObjects are powerful for data, but often require manual setup and boilerplate. EasyCS provides **fully automated creation and management for data configurations** using ScriptableObjects, drastically reducing routine work and improving your workflow for game data.  
* **Clear Execution Flow:** Unlike Unity's default MonoBehaviour execution order, which can sometimes be unpredictable across multiple scripts, EasyCS provides a **clear, defined order for initialization and updates** (e.g., OnAwake, OnUpdate). This predictability makes debugging and understanding complex systems much easier.  
* **Better Unity Experience:** Unity's default approach can get messy as projects grows. EasyCS aims to **improve how you work in the Unity editor** by giving you a more organized way to manage game data and logic. It brings architectural benefits without making you abandon familiar Unity tools.  
* **Practicality First:** Most game projects don't fully switch to ECS, despite its architectural strengths. EasyCS offers a **balanced, practical solution**. It's not meant to replace powerful, production-level ECS frameworks, but to provide a clear, understandable option for common development tasks where ECS principles help, but a full migration isn't needed or wanted.

EasyCS is an **evolving framework** designed to be intuitive and easy to integrate. It helps developers solve real problems like separating data and logic, or using ScriptableObjects efficiently, all without the high barrier to entry or big refactoring demands of other solutions. It's about empowering Unity developers to build stronger, more maintainable games, step by step.


---

## 🌟 Features at a Glance
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

## 🔍 Framework Comparison Table

| Feature / Capability                        | Classic Unity            | Zenject / VContainer DI                     | Classical ECS               | 🧩 **EasyCS**                         |
|--------------------------------------------|---------------------------|---------------------------------------------|-----------------------------|--------------------------------------|
| ✅ **ScriptableObject Integration**         | ❌ Manual, boilerplate     | 🟡 Manual or per-pattern                     | ❌ Not used                  | ✅ Native + Automated                |
| 🧱 **Component Modularity**                 | 🟡 MonoBehavior composition | 🟡 Service-level modularity only             | ✅ System-defined archetypes | ✅ Behavior + Data Layers           |
| 🔄 **Instantiate / Destroy Entities**       | 🟡 GameObject.Destroy      | 🟡 Unity-style destruction                   | ✅ Built-in, loop-friendly   | ✅ Entity-aware creation/destruction|
| 💾 **Save System Compatibility**              | ❌ Requires boilerplate     | 🟡 DI-friendly but needs logic               | ✅ Loopable + serializable data   | ✅ Loopable + serializable data     |
| 🧩 **Entity Construction**                  | ❌ Manual Mono setup        | 🟡 Scene installers + custom prefabs         | ✅ Data-defined archetypes   | ✅ Prefab + Scriptable Entity setup |
| 🧠 **MonoBehaviour Reuse**                  | ✅ Built-in                 | 🟡 Wrapped in services                       | 🟡 Requires refactoring      | ✅ Retains Unity-style reuse        |
| 🧩 **Monobehavior Data Injection**          | ❌ Manual references        | 🟡 Needs custom installers                   | ❌ Not designed for it       | ✅ Declarative and automatic       |
| 🏁 **Entry Point (Lifecycle Bootstrap)**    | ❌ None                     | ✅ Custom installers                         | ✅ System-based              | ✅ EasyCSInstaller                  |
| 🔁 **Loop-Ready Monobehavior Data Access**  | ❌ None                     | 🟡 Partial (registered only)                | 🟡 Only for Entity           | ✅ Native per Entity/Actor access         |
| ⚡ **Conversion from Existing Code**        | —                          | 🟡 Needs wrapping in services                | ❌ Full refactor required    | ✅ Easy MonoBehaviour conversion    |
| 💡 **Learning Curve**                       | ✅ Familiar                 | 🟡 Moderate (DI concepts)                    | ❌ High (ECS paradigm shift) | ✅ Low, Unity-like feel             |
| 🔌 **Compatible with DI Frameworks**        | 🟡 With adapters            | ✅ Native                                    | 🟡 Partial & Manual           | ✅ Optional & Out-Of-Box            |
| ⚡ **Logic Reactivity**                    | ✅ Native                    | ✅ Native                                   | 🟡 Frame-delayed             | ✅ Native                           |
| 🧪 **Prototype Friendliness**              | ✅ Easy with technical dept  | 🟡 Needs additional setup                    | ❌ Not friendly              | ✅ Near Native                    |
| 🧰 **Editor-Friendliness**                 | 🟡 Familiar but limited     | 🟡 Same as Unity                             | ❌ Poor integration          | ✅ Enchanced & Prioritized       |
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
| Odin Validator     | Editor-Validation System     | ✅        |

---

## **Frequently Asked Questions (FAQ)**

### **Is EasyCS just another ECS framework?**

No, EasyCS is not an ECS (Entity-Component-System) framework in the classic, strict sense. It draws inspiration from data-oriented design and ECS principles by emphasizing the decoupling of data from logic, but it doesn't force a full paradigm shift like DOTS or other pure ECS solutions. EasyCS is designed to be more flexible and integrates seamlessly with Unity's traditional MonoBehaviour workflow, allowing you to adopt data-oriented practices incrementally without a complete architectural overhaul. It focuses on usability and development speed for a broader range of Unity projects.

### **Is EasyCS as complex and slow to develop with as other ECS frameworks?**

Absolutely not. One of the core motivations behind EasyCS is to reduce the complexity and development overhead often associated with traditional ECS. Pure ECS solutions can have a steep learning curve and may slow down initial prototyping due to their strict architectural requirements. EasyCS is built for **fast-paced prototyping** and **simple integration**, allowing you to improve your project's architecture incrementally. You get the benefits of data-oriented design without the "all-or-nothing" commitment and steep learning curve that can hinder development speed.

### **EasyCS vs. other ECS (like Unity DOTS)?**

Use EasyCS for **simple to mid-core projects** where development speed, clear architecture, and smooth Unity integration are key. Choose DOTS for **massive performance** needs (hundreds of thousands of simulated entities). If you're already proficient with another ECS and have an established pipeline, stick with it.

### **I'm using DI (Zenject, VContainer) do I need EasyCS?**

Yes, EasyCS is **compatible with DI frameworks** like Zenject and VContainer, but it's not required. While DI manages global services and dependencies across your application, EasyCS focuses on structuring individual game objects (Actors) and their local data. EasyCS components are well-structured and injectable, complementing your DI setup by providing cleaner, modular building blocks for game entities, avoiding custom boilerplate for local object data management.

### **Is EasyCS suitable for Junior, Mid, or Senior developers?**

EasyCS offers benefits across all experience levels. For **Junior and Mid-level developers**, it provides a gentle introduction to data-oriented design and helps build better coding habits. For **Senior developers**, it serves as a practical tool to incrementally improve existing projects, avoid common "reinventing the wheel" scenarios, and streamline development workflows.

### **What kind of games can be made with EasyCS?**

EasyCS is ideal for a **wide range of projects** where robust architecture, clear data flow, and efficient editor workflows are critical. It excels at making individual game systems cleaner and more manageable.

* **Ideal for:**  
  * **Small to Mid-core Projects:** This includes single-player experiences and games with moderate complexity.  
  * **Prototypes & Small Projects:** Quickly build and iterate with a clean architectural foundation.  
  * **Games requiring full game state serialization and an out-of-the-box save system compatibility**, thanks to its decoupled data approach.  
  * **Cross-Genre Applicability:** Suitable for diverse genres like puzzle, casual, strategy, RPGs, and action games.  
  * **Multi-Platform Development:** Supports development on Mobile, PC, and other platforms where Unity is used.

### **What kind of games are *not* ideal for EasyCS?**

While highly flexible, EasyCS is not optimized for **extreme, large-scale data-oriented performance**.

* **Not ideal for (or requires manual implementation):**  
  * Games requiring simulation of **millions of entities simultaneously** (e.g., highly complex simulations, massive real-time strategy games with vast unit counts, very dense physics simulations). For these, pure, low-level ECS like Unity DOTS is more appropriate.  
  * Games with **complex built-in multiplayer synchronization** (Entity-data is not automatically synced across clients; this mechanism needs to be implemented manually, though it's planned for future improvement).

### **Do I need to update all MonoBehaviours to EasyCS?**

No, **a complete migration of all your existing MonoBehaviours is absolutely not required**. EasyCS is designed for seamless integration with your current codebase. You can introduce EasyCS incrementally, refactoring specific MonoBehaviours or building new features using its principles, while the rest of your project continues to function as before. This allows you to adopt the framework at your own pace and where it provides the most value.

### **Can Entities and Data exist independently of Unity GameObjects?**

Yes, they absolutely can\! EasyCS is designed with a clear separation of concerns:

* **Entity-Layer (Pure Game Logic Data):** By default, **pure game logic data** (like player stats, inventory items, or quest states) resides in classes inheriting from **EntityDataBase or EntityDataCustomBase**. These are **plain C\# classes** and do **not** inherit from MonoBehaviour. This means you can create, manage, and process them entirely in code, independent of any GameObject in your Unity scene. This is ideal for core game data that doesn't inherently need a visual representation or direct Unity component interaction.  
* **Actor-Layer (Unity Data & GameObject Links):** Classes inheriting from **ActorData and ActorBehavior** **do** inherit from MonoBehaviour. They are designed to hold **Unity-specific data and GameObject links** (like a Rigidbody reference, transform data, or mesh renderer references) and to provide the bridge between your decoupled Entity data and Unity's scene hierarchy.

This clear distinction gives you the flexibility to manage your game's core data logic separately from its Unity representation, leading to cleaner architecture and more robust systems.

### **How to migrate my MonoBehaviours to EasyCS?**

Migrating existing MonoBehaviours to EasyCS is designed to be a **gradual and controlled process**, not a forced rewrite. It allows you to transform your existing tightly coupled MonoBehaviours into modular, data-driven components.  
Let's compare how a simple player movement system might be implemented in a traditional Unity approach versus using EasyCS. This highlights how EasyCS separates data from logic for cleaner, more modular code, illustrating the migration process.

#### **Before Migration: Standard MonoBehaviour**

In a typical Unity setup, movement logic and the Rigidbody component are often tightly coupled within a single MonoBehaviour.  

```csharp
public class PlayerMovement : MonoBehaviour  
{
    [SerializeField]
    private float _moveSpeed = 5f;
    [SerializeField]
    private Rigidbody _rb;
    
    void FixedUpdate()  
    {  
        float horizontalInput = Input.GetAxis("Horizontal");  
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        Vector3 nextPosition = _rb.position + moveDirection * _moveSpeed * Time.fixedDeltaTime;

        _rb.MovePosition(nextPosition);
    }  
}
```

**Key Points:**

* **Tight Coupling:** The moveSpeed data and the movement logic are both inside the PlayerMovementTraditional MonoBehaviour.  
* **Direct Dependency:** The script directly depends on and controls the Rigidbody component.  
* **Less Reusable:** This specific movement logic is designed for this MonoBehaviour.

#### **After Migration: Decoupled Data and Behavior with EasyCS**

EasyCS allows you to define movement data (EntityDataMove) separately from the Rigidbody data (ActorDataRigidbody) and then bind them to an ActorBehaviorMove that performs the logic.  

```csharp

// Use EntityData for configuration and runtime data. Do not user for storing UnityEngine.Objects
[Serializable] // (Optional) Apply [RuntimeOnly] attribute for data that does not require setup from inspector(runtime data)
public class EntityDataMoveSpeed : EntityDataBase<float>  {  }

// Use ActorData for linking GameObjects/Transform/Components within the GameObject hierarchy
// For linking assets(prefabs, sprites, textures etc.) use ActorDataSharedBase
// Ensure class is partial for compatibility with code generation
public partial class ActorDataRigidbody : ActorData
{  
    [field: SerializeField, Required]  
    public Rigidbody Rigidbody { get; private set; }  
}

// Ensure class is partial for compatibility with code generation
// Replace the Monobehavior with ActorBehavior
public partial class ActorBehaviorMove : ActorBehavior, IFixedUpdate // Implement required callbacks for your logic(IFixedUpdate)
{  
    [Bind]  
    private EntityDataMoveSpeed _dataMoveSpeed;  
    [Bind]  
    private ActorDataRigidbody _dataRigidbody;

    public void OnFixedUpdate(float deltaTime)  
    {
        float horizontalInput = Input.GetAxis("Horizontal");  
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        Vector3 nextPosition = _dataRigidbody.Rigidbody.position + moveDirection * _dataMoveSpeed.Value * deltaTime;

        _dataRigidbody.Rigidbody.MovePosition(nextPosition);  
    }  
}

```

**Note:** Don't forget to attach `Actor` component to your GameObject

**Key Steps and Benefits of Migration:**

1. **Identify and Separate Data:** The moveSpeed and Rigidbody references are extracted into dedicated data components: EntityDataMove (for the conceptual movement input/direction) and ActorDataRigidbody (for the Rigidbody component itself). These are now separate, reusable pieces of data.  
2. **Refactor Logic to ActorBehavior:** The movement logic from the original FixedUpdate is moved into ActorBehaviorMove. This class inherits from ActorBehavior, which is Unity-compatible but integrates with EasyCS's system.  
3. **Automatic Data Binding:** The [Bind] attribute automatically injects the EntityDataMove and ActorDataRigidbody instances into ActorBehaviorMove. This eliminates manual GetComponent calls and direct references, making dependencies clear and managed by the framework.  
4. **Modular and Testable:** The data components are now independent, making them easier to test in isolation. The ActorBehaviorMove focuses purely on movement logic, improving its clarity and testability.  
5. **Editor-Friendly:** The [Bind] attribute not only automates data assignment but also ensures that all required dependencies are validated in the Inspector, providing instant feedback if anything is missing.

This approach allows you to refactor your codebase piece by piece, gradually benefiting from EasyCS's architectural improvements without stopping ongoing development.

---

## ⚙️ Setup

1. Go to releases and download Unity package:

https://github.com/Watcher3056/EasyCS-Submodule/releases

2. Import `.unitypackage` to your project

3. Import Unity package `com.unity.2d.animation` or `com.unity.2d` from Package Manager

4. Attach `EasyCSInstaller` component to GameObject on scene

---

### (Optional) ⚙️ Setup with VContainer

5. Add `VCONTAINER_ENABLED` keyword in `Edit > Project Settings > Player > Scripting Define Symbols` then press "Apply"
6. Attach `LifeTimeScopeWithInstallers` component on the same GameObject as before
7. Drag-n-Drop `EasyCSInstaller` into `Installers` list on `LifeTimeScopeWithInstallers`

---

### (Optional) ⚙️ Setup with Zenject

5. Add `ZENJECT_ENABLED` keyword in `Edit > Project Settings > Player > Scripting Define Symbols` then press "Apply"
6. Make sure to attach `EasyCSInstaller` component on the GameObject with `SceneContext`
7. Drag-n-Drop `EasyCSInstaller` into `Mono Installers` list on `SceneContext`

---


## 📚 Examples

1. Download this repository
2. Check: `Assets/EasyCS-Samples/`

---

## 💬 Join the Community

Have questions, feedback, or ideas? Join our Discord server to chat with other developers, share your projects, or get help from the EasyCS community!

👉 [Join our Discord](https://discord.gg/d4CccJAMQc)

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

## EntityTemplateAsset

- Provides a way to define templates(archetypes) for `Entity`, to optimize the workflow even more
- Compatible with `Actor` and `EntityFactory` features

Downsides:
- Can be messy to work with on `Actor` so better use for creating `Entity` that don't need gameobject(plain objects), such as Inventory Items, etc.

![Alt Text](https://i.imgur.com/Ifgrprc.png)

---

## EntityPredefinedScriptableObject

![Alt Text](https://i.imgur.com/CEwGBtq.png)

- Allows you to serialize `Entity.ID` and restore it access it later
- Provides storage for `Entity.ID` in asset, allowing cross-scene and cross-session references
- Static and never changes between builds

---

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
