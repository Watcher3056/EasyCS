using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS.Samples
{
    [DrawWithTriInspector]
    [AddComponentMenu("EasyCS/Entity/Data/Data Attack")]
    public partial class EntityDataProviderAttack : EntityDataProvider<EntityDataFactoryAttack, EntityDataAttack>
    {
    }
}