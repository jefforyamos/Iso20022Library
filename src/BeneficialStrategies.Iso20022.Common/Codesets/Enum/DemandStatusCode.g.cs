﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DemandStatusCode.  ISO2002 ID# _xyDjAHyYEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the demand for payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xyDjAHyYEeGWJuGCfvwOsQ")]
[Description(@"Specifies the status of the demand for payment.")]
[Derivations(typeof(DemandStatus1Code),typeof(DemandStatus2Code))]
// External derivations that should be provided by the proper interface are: 
public enum DemandStatusCode
{
    /// <summary>
    /// Demand refused.
    /// Encoded/decoded by serializers as "REFD".
    /// </summary>
    [EnumMember(Value = "REFD")]
    [IsoId("_V0vHEHyZEeGWJuGCfvwOsQ")]
    [Description(@"Demand refused.")]
    Refused,
    
    /// <summary>
    /// Extend undertaking expiry date.
    /// Encoded/decoded by serializers as "EXTD".
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_WJq0INryEeGuxusC7C-WeA")]
    [Description(@"Extend undertaking expiry date.")]
    Extend,
    
    /// <summary>
    /// Pay undertaking demand.
    /// Encoded/decoded by serializers as "PAYD".
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_nrhhUNryEeGuxusC7C-WeA")]
    [Description(@"Pay undertaking demand.")]
    PAY,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DemandStatusCodeMetadataExtensions
{
    private static readonly DemandStatusCodeDropdownSource _dropdownSource = new DemandStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDemandStatusCodeDropdownRow GetMetadata(this DemandStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


