using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS.Samples
{
    [DrawWithTriInspector]
    [AddComponentMenu("EasyCS/Entity/Data/Data Attack Damage")]
    public partial class EntityDataProviderAttackDamage : EntityDataProvider<EntityDataFactoryAttackDamage, EntityDataAttackDamage>
    {
    }
}