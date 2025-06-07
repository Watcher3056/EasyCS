using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS.Samples
{
    [DrawWithTriInspector]
    [AddComponentMenu("EasyCS/Entity/Data/Data Health Max")]
    public partial class EntityDataProviderHealthMax : EntityDataProvider<EntityDataFactoryHealthMax, EntityDataHealthMax>
    {
    }
}