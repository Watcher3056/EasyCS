using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS.Samples
{
    [DrawWithTriInspector]
    [CreateAssetMenu(fileName = "EntityDataFactoryAttack", menuName = "EasyCS/Entity Data Factories/EntityDataAttack")]
    public partial class EntityDataFactoryAttack : EntityDataFactory<EntityDataAttack>
    {
    }
}