using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS.Samples
{
    [DrawWithTriInspector]
    [AddComponentMenu("EasyCS/Entity/Data/Data Move Speed")]
    public partial class EntityDataProviderMoveSpeed : EntityDataProvider<EntityDataFactoryMoveSpeed, EntityDataMoveSpeed>
    {
    }
}