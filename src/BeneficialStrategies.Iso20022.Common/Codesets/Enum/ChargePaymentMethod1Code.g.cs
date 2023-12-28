﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ChargePaymentMethod1Code.  ISO2002 ID# _ZFE3gBXyEeOBE-jZfcm4KQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how expenses are paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFE3gBXyEeOBE-jZfcm4KQ")]
[Description(@"Specifies how expenses are paid.")]
[DerivedFrom(typeof(ChargePaymentMethodCode))]
public enum ChargePaymentMethod1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Cash".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_T2UeMRXzEeOBE-jZfcm4KQ")]
    [Description(@"??")]
    Cash,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unit".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_UAJIkRXzEeOBE-jZfcm4KQ")]
    [Description(@"??")]
    Unit,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ChargePaymentMethod1CodeMetadataExtensions
{
    private static readonly ChargePaymentMethod1CodeDropdownSource _dropdownSource = new ChargePaymentMethod1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IChargePaymentMethod1CodeDropdownRow GetMetadata(this ChargePaymentMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


