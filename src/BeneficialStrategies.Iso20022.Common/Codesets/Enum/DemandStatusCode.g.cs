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
public enum DemandStatusCode
{
    /// <summary>
    /// Demand refused.
    /// </summary>
    [EnumMember(Value = "REFD")]
    [IsoId("_V0vHEHyZEeGWJuGCfvwOsQ")]
    [Description(@"Demand refused.")]
    REFD,
    
    /// <summary>
    /// Extend undertaking expiry date.
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_WJq0INryEeGuxusC7C-WeA")]
    [Description(@"Extend undertaking expiry date.")]
    EXTD,
    
    /// <summary>
    /// Pay undertaking demand.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_nrhhUNryEeGuxusC7C-WeA")]
    [Description(@"Pay undertaking demand.")]
    PAYD,
    
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


