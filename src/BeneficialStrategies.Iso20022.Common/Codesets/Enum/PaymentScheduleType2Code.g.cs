﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentScheduleType2Code.  ISO2002 ID# _gbgLkLb0Eeu9Cp6InX88Vw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a payment schedule type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gbgLkLb0Eeu9Cp6InX88Vw")]
[Description(@"Specifies a payment schedule type.")]
[DerivedFrom(typeof(PaymentScheduleTypeCode))]
public enum PaymentScheduleType2Code
{
    /// <summary>
    /// Payment schedule is defined as per contract.
    /// Encoded/decoded by serializers as "Contract".
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_k51YEbb0Eeu9Cp6InX88Vw")]
    [Description(@"Payment schedule is defined as per contract.")]
    Contract,
    
    /// <summary>
    /// Payment schedule is estimated.
    /// Encoded/decoded by serializers as "Estimated".
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_k-B7kbb0Eeu9Cp6InX88Vw")]
    [Description(@"Payment schedule is estimated.")]
    Estimated,
    
    /// <summary>
    /// Contract Payment schedule is both defined as per Contract and estimated.
    /// Encoded/decoded by serializers as "Both".
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_pFQPobb0Eeu9Cp6InX88Vw")]
    [Description(@"Contract Payment schedule is both defined as per Contract and estimated.")]
    Both,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentScheduleType2CodeMetadataExtensions
{
    private static readonly PaymentScheduleType2CodeDropdownSource _dropdownSource = new PaymentScheduleType2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentScheduleType2CodeDropdownRow GetMetadata(this PaymentScheduleType2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


