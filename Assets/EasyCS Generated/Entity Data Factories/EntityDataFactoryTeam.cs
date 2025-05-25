using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine; // Required for CreateAssetMenu

namespace EasyCS
{
    [CreateAssetMenu(fileName = "EntityDataFactoryTeam", menuName = "EasyCS/Entity Data Factories/EntityDataTeam")] // Menu name based on base name
    public partial class EntityDataFactoryTeam : EntityDataFactory<EntityDataTeam> // Use partial
    {
    }
}