using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS.Samples
{
    [DrawWithTriInspector]
    [AddComponentMenu("EasyCS/Entity/Behavior/Behavior Health")]
    public partial class EntityBehaviorProviderHealth : EntityBehaviorProvider<EntityBehaviorHealth>
    {
    }
}