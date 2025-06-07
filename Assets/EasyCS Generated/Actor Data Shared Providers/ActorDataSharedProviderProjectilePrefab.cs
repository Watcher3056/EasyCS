using EasyCS;
using UnityEngine;
using TriInspector;

namespace EasyCS.Samples
{
    [DrawWithTriInspector]
    [AddComponentMenu("EasyCS/Actor/Data/Data Projectile Prefab")]
    public partial class ActorDataSharedProviderProjectilePrefab : ActorDataSharedProviderBase<ActorDataSharedProjectilePrefab, ActorDataSharedFactoryProjectilePrefab>
    {
    }
}