﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DemandStatus1Code.  ISO2002 ID# _FQp0QHyaEeGWJuGCfvwOsQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the demand for payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FQp0QHyaEeGWJuGCfvwOsQ")]
[Description(@"Specifies the status of the demand for payment.")]
[DerivedFrom(typeof(DemandStatusCode))]
public enum DemandStatus1Code
{
    /// <summary>
    /// Extend undertaking expiry date.
    /// Encoded/decoded by serializers as "EXTD".
    /// </summary>
    [EnumMember(Value = "EXTD")]
    [IsoId("_wyDoAdryEeGuxusC7C-WeA")]
    [Description(@"Extend undertaking expiry date.")]
    Extend = DemandStatusCode.Extend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Pay undertaking demand.
    /// Encoded/decoded by serializers as "PAYD".
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_w7l-gdryEeGuxusC7C-WeA")]
    [Description(@"Pay undertaking demand.")]
    PAY = DemandStatusCode.PAY, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DemandStatus1CodeMetadataExtensions
{
    private static readonly DemandStatus1CodeDropdownSource _dropdownSource = new DemandStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDemandStatus1CodeDropdownRow GetMetadata(this DemandStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


