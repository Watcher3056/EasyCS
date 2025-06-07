using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS
{
    [DrawWithTriInspector]
    [AddComponentMenu("EasyCS/Entity/Data/Data Name")]
    public partial class EntityDataProviderName : EntityDataProvider<EntityDataFactoryName, EntityDataName>
    {
    }
}