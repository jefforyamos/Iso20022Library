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
public enum DemandTypeCode
{
    /// <summary>
    /// Pay only.
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_vHYM0HyVEeGWJuGCfvwOsQ")]
    [Description(@"Pay only.")]
    PAYM,
    
    /// <summary>
    /// Pay or extend.
    /// </summary>
    [EnumMember(Value = "PAEX")]
    [IsoId("_qaP54HyWEeGWJuGCfvwOsQ")]
    [Description(@"Pay or extend.")]
    PAEX,
    
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


