﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for POIComponentStatusCode.  ISO2002 ID# _d4opsAxwEeKa_56Jbsi1RQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Status of a component belonging to a POI Terminal (Point of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_d4opsAxwEeKa_56Jbsi1RQ")]
[Description(@"Status of a component belonging to a POI Terminal (Point of Interaction).")]
[Derivations(typeof(POIComponentStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum POIComponentStatusCode
{
    /// <summary>
    /// Component not yet activated.
    /// Encoded/decoded by serializers as "WAIT".
    /// </summary>
    [EnumMember(Value = "WAIT")]
    [IsoId("_rAURoAxwEeKa_56Jbsi1RQ")]
    [Description(@"Component not yet activated.")]
    WaitingActivation,
    
    /// <summary>
    /// Component activated and in operation.
    /// Encoded/decoded by serializers as "OPER".
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_09qrkAxwEeKa_56Jbsi1RQ")]
    [Description(@"Component activated and in operation.")]
    InOperation,
    
    /// <summary>
    /// Component not working properly.
    /// Encoded/decoded by serializers as "OUTD".
    /// </summary>
    [EnumMember(Value = "OUTD")]
    [IsoId("_6gMgAAxwEeKa_56Jbsi1RQ")]
    [Description(@"Component not working properly.")]
    OutOfOrder,
    
    /// <summary>
    /// Component has been deactivated.
    /// Encoded/decoded by serializers as "DACT".
    /// </summary>
    [EnumMember(Value = "DACT")]
    [IsoId("__5DbEAxwEeKa_56Jbsi1RQ")]
    [Description(@"Component has been deactivated.")]
    Deactivated,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class POIComponentStatusCodeMetadataExtensions
{
    private static readonly POIComponentStatusCodeDropdownSource _dropdownSource = new POIComponentStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPOIComponentStatusCodeDropdownRow GetMetadata(this POIComponentStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


