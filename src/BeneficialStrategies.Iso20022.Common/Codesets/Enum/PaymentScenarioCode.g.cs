﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentScenarioCode.  ISO2002 ID# _rJyl4DKlEeipv8GJ5uBgPw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the payment scenario used for a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rJyl4DKlEeipv8GJ5uBgPw")]
[Description(@"Describes the payment scenario used for a payment transaction.")]
public enum PaymentScenarioCode
{
    /// <summary>
    /// Indicates cover payment(s).
    /// </summary>
    [EnumMember(Value = "COVE")]
    [IsoId("_5KoqcDKlEeipv8GJ5uBgPw")]
    [Description(@"Indicates cover payment(s).")]
    COVE,
    
    /// <summary>
    /// Indicates customer credit transfer(s).
    /// </summary>
    [EnumMember(Value = "CCTR")]
    [IsoId("_rs1SUHYhEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s).")]
    CCTR,
    
    /// <summary>
    /// Indicates customer credit transfer(s) and cover(s).
    /// </summary>
    [EnumMember(Value = "CTCO")]
    [IsoId("_xw0OAHYhEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s) and cover(s).")]
    CTCO,
    
    /// <summary>
    /// Indicates customer credit transfer(s) without cover.
    /// </summary>
    [EnumMember(Value = "CCTW")]
    [IsoId("_u4b2MHYiEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s) without cover.")]
    CCTW,
    
    /// <summary>
    /// Indicates customer credit transfer(s) with cover.
    /// </summary>
    [EnumMember(Value = "CCTC")]
    [IsoId("_7WlY8HYiEei7x9Ux0Cio1w")]
    [Description(@"Indicates customer credit transfer(s) with cover.")]
    CCTC,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentScenarioCodeMetadataExtensions
{
    private static readonly PaymentScenarioCodeDropdownSource _dropdownSource = new PaymentScenarioCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentScenarioCodeDropdownRow GetMetadata(this PaymentScenarioCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


