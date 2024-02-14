﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RoutingTypeCode.  ISO2002 ID# _Y-eU4Np-Ed-ak6NoX_4Aeg_-770553292.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of routing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-eU4Np-Ed-ak6NoX_4Aeg_-770553292")]
[Description(@"Indicates the type of routing.")]
[Derivations(typeof(RoutingType1Code))]
public enum RoutingTypeCode
{
    /// <summary>
    /// Indicates that routing is allowed.
    /// Encoded/decoded by serializers as &quot;ALLO&quot;.
    /// </summary>
    [EnumMember(Value = "ALLO")]
    [IsoId("_Y-eU4dp-Ed-ak6NoX_4Aeg_-713294906")]
    [Description(@"Indicates that routing is allowed.")]
    Allowed,
    
    /// <summary>
    /// Indicates that routing is blocked.
    /// Encoded/decoded by serializers as &quot;BLOC&quot;.
    /// </summary>
    [EnumMember(Value = "BLOC")]
    [IsoId("_Y-eU4tp-Ed-ak6NoX_4Aeg_-697596993")]
    [Description(@"Indicates that routing is blocked.")]
    Blocked,
    
}
