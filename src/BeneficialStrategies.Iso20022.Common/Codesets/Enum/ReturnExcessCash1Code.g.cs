﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReturnExcessCash1Code.  ISO2002 ID# _tL3U4ALoEeutW5-TpeYJhA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies information about excess cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tL3U4ALoEeutW5-TpeYJhA")]
[Description(@"Specifies information about excess cash.")]
[DerivedFrom(typeof(ReturnExcessCashCode))]
public enum ReturnExcessCash1Code
{
    /// <summary>
    /// Excess cash in the currency is returned.
    /// Encoded/decoded by serializers as "RTND".
    /// </summary>
    [EnumMember(Value = "RTND")]
    [IsoId("_u2qp0QLoEeutW5-TpeYJhA")]
    [Description(@"Excess cash in the currency is returned.")]
    AutomaticallyReturned = ReturnExcessCashCode.AutomaticallyReturned, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Automatic return of excess cash has not been requested for the currency. 
    /// Encoded/decoded by serializers as "RTDN".
    /// </summary>
    [EnumMember(Value = "RTDN")]
    [IsoId("_vAVjMgLoEeutW5-TpeYJhA")]
    [Description(@"Automatic return of excess cash has not been requested for the currency. ")]
    NoAutomaticReturn = ReturnExcessCashCode.NoAutomaticReturn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Automatic return of cash is temporarily suspended (for example due to a currency holiday).
    /// Encoded/decoded by serializers as "SSPD".
    /// </summary>
    [EnumMember(Value = "SSPD")]
    [IsoId("_vKC40gLoEeutW5-TpeYJhA")]
    [Description(@"Automatic return of cash is temporarily suspended (for example due to a currency holiday).")]
    Suspended = ReturnExcessCashCode.Suspended, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ReturnExcessCash1CodeMetadataExtensions
{
    private static readonly ReturnExcessCash1CodeDropdownSource _dropdownSource = new ReturnExcessCash1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IReturnExcessCash1CodeDropdownRow GetMetadata(this ReturnExcessCash1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


