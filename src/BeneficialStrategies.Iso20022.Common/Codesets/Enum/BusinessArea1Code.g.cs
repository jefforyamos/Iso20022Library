﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BusinessArea1Code.  ISO2002 ID# _JfLxsE4OEey_VecAUE-C9Q.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the business context of the transaction
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JfLxsE4OEey_VecAUE-C9Q")]
[Description(@"Specifies the business context of the transaction")]
[DerivedFrom(typeof(BusinessAreaCode))]
public enum BusinessArea1Code
{
    /// <summary>
    /// The payment is initiated by an artificial intelligence based decision.
    /// Encoded/decoded by serializers as "AIBD".
    /// </summary>
    [EnumMember(Value = "AIBD")]
    [IsoId("_RZiZIU4OEey_VecAUE-C9Q")]
    [Description(@"The payment is initiated by an artificial intelligence based decision.")]
    ArtificialIntelligenceBasedDecision = BusinessAreaCode.ArtificialIntelligenceBasedDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card is used in a Transit business case where the fare amount is not known when the transaction is initiated.
    /// Encoded/decoded by serializers as "OPMT".
    /// </summary>
    [EnumMember(Value = "OPMT")]
    [IsoId("_RgShYU4OEey_VecAUE-C9Q")]
    [Description(@"The card is used in a Transit business case where the fare amount is not known when the transaction is initiated.")]
    Openpayment = BusinessAreaCode.Openpayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card is used to perform a plain payment.
    /// Encoded/decoded by serializers as "PPAY".
    /// </summary>
    [EnumMember(Value = "PPAY")]
    [IsoId("_RrhhAU4OEey_VecAUE-C9Q")]
    [Description(@"The card is used to perform a plain payment.")]
    PlainPayment = BusinessAreaCode.PlainPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card is used in a Transit business case where the fare amount is known when the transaction is initiated.
    /// Encoded/decoded by serializers as "TKNF".
    /// </summary>
    [EnumMember(Value = "TKNF")]
    [IsoId("_RzNdYU4OEey_VecAUE-C9Q")]
    [Description(@"The card is used in a Transit business case where the fare amount is known when the transaction is initiated.")]
    TransitKnownFare = BusinessAreaCode.TransitKnownFare, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BusinessArea1CodeMetadataExtensions
{
    private static readonly BusinessArea1CodeDropdownSource _dropdownSource = new BusinessArea1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBusinessArea1CodeDropdownRow GetMetadata(this BusinessArea1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


