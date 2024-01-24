﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentScheduleType1Code.  ISO2002 ID# _y3zBIAqPEeWqX7rjSIiMuQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a payment schedule type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_y3zBIAqPEeWqX7rjSIiMuQ")]
[Description(@"Specifies a payment schedule type.")]
[DerivedFrom(typeof(PaymentScheduleTypeCode))]
public enum PaymentScheduleType1Code
{
    /// <summary>
    /// Payment schedule is defined as per contract.
    /// Encoded/decoded by serializers as "CNTR".
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_0Cn1gQqPEeWqX7rjSIiMuQ")]
    [Description(@"Payment schedule is defined as per contract.")]
    Contract = PaymentScheduleTypeCode.Contract, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment schedule is estimated.
    /// Encoded/decoded by serializers as "ESTM".
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_0H1FoQqPEeWqX7rjSIiMuQ")]
    [Description(@"Payment schedule is estimated.")]
    Estimated = PaymentScheduleTypeCode.Estimated, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentScheduleType1CodeMetadataExtensions
{
    private static readonly PaymentScheduleType1CodeDropdownSource _dropdownSource = new PaymentScheduleType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentScheduleType1CodeDropdownRow GetMetadata(this PaymentScheduleType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


