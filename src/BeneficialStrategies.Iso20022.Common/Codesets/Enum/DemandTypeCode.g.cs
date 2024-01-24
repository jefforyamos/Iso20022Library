﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DemandTypeCode.  ISO2002 ID# _XvpRYHyVEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of demand for payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XvpRYHyVEeGWJuGCfvwOsQ")]
[Description(@"Specifies the type of demand for payment.")]
[Derivations(typeof(DemandType1Code))]
public enum DemandTypeCode
{
    /// <summary>
    /// Pay only.
    /// Encoded/decoded by serializers as "PAYM".
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_vHYM0HyVEeGWJuGCfvwOsQ")]
    [Description(@"Pay only.")]
    PayOnly,
    
    /// <summary>
    /// Pay or extend.
    /// Encoded/decoded by serializers as "PAEX".
    /// </summary>
    [EnumMember(Value = "PAEX")]
    [IsoId("_qaP54HyWEeGWJuGCfvwOsQ")]
    [Description(@"Pay or extend.")]
    PayOrExtend,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DemandTypeCodeMetadataExtensions
{
    private static readonly DemandTypeCodeDropdownSource _dropdownSource = new DemandTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDemandTypeCodeDropdownRow GetMetadata(this DemandTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


