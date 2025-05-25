using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine; // Required for CreateAssetMenu

namespace EasyCS.Samples
{
    [CreateAssetMenu(fileName = "EntityDataFactoryAttackDamage", menuName = "EasyCS/Entity Data Factories/EntityDataAttackDamage")] // Menu name based on base name
    public partial class EntityDataFactoryAttackDamage : EntityDataFactory<EntityDataAttackDamage> // Use partial
    {
    }
}