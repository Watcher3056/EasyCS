using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS
{
    [DrawWithTriInspector]
    [AddComponentMenu("EasyCS/Entity/Data/Data Team")]
    public partial class EntityDataProviderTeam : EntityDataProvider<EntityDataFactoryTeam, EntityDataTeam>
    {
    }
}