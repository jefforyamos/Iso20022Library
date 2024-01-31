﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PaymentReceiptCode.  ISO2002 ID# _oMVPoA5EEeenr-7g_0TYag.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if an operation is a payment, or a receipt or none.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oMVPoA5EEeenr-7g_0TYag")]
[Description(@"Specifies if an operation is a payment, or a receipt or none.")]
[Derivations(typeof(PaymentReceipt1Code))]
public enum PaymentReceiptCode
{
    /// <summary>
    /// Operation is a payment.
    /// Encoded/decoded by serializers as "PAYM".
    /// </summary>
    [EnumMember(Value = "PAYM")]
    [IsoId("_t7Wn8A5EEeenr-7g_0TYag")]
    [Description(@"Operation is a payment.")]
    Payment,
    
    /// <summary>
    /// Operation is a receipt.
    /// Encoded/decoded by serializers as "RECE".
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_yRapQA5EEeenr-7g_0TYag")]
    [Description(@"Operation is a receipt.")]
    Receipt,
    
    /// <summary>
    /// Operation is null.
    /// Encoded/decoded by serializers as "NONE".
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_2kqAEA5EEeenr-7g_0TYag")]
    [Description(@"Operation is null.")]
    None,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PaymentReceiptCodeMetadataExtensions
{
    private static readonly PaymentReceiptCodeDropdownSource _dropdownSource = new PaymentReceiptCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPaymentReceiptCodeDropdownRow GetMetadata(this PaymentReceiptCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


