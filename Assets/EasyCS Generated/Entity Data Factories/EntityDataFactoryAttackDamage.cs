using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS.Samples
{
    [DrawWithTriInspector]
    [CreateAssetMenu(fileName = "EntityDataFactoryAttackDamage", menuName = "EasyCS/Entity Data Factories/EntityDataAttackDamage")]
    public partial class EntityDataFactoryAttackDamage : EntityDataFactory<EntityDataAttackDamage>
    {
    }
}