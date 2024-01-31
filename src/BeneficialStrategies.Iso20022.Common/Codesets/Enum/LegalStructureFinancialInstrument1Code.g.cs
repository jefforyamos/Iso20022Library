﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LegalStructureFinancialInstrument1Code.  ISO2002 ID# _WAtaIDcVEeiIxKQErQxblg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the legal structure of a financial instrument as defined in the scope of European MiFID Template (EMT) reference 00060.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WAtaIDcVEeiIxKQErQxblg")]
[Description(@"Specifies the legal structure of a financial instrument as defined in the scope of European MiFID Template (EMT) reference 00060.")]
[DerivedFrom(typeof(LegalStructureFinancialInstrumentCode))]
public enum LegalStructureFinancialInstrument1Code
{
    /// <summary>
    /// Legal structure is a not an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as "NUCI".
    /// </summary>
    [EnumMember(Value = "NUCI")]
    [IsoId("_X3bEITcVEeiIxKQErQxblg")]
    [Description(@"Legal structure is a not an Undertaking for Collective Investment in Transferable Securities (UCITS).")]
    NonUCITS = LegalStructureFinancialInstrumentCode.NonUCITS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal structure is a structured fund.
    /// Encoded/decoded by serializers as "SFUN".
    /// </summary>
    [EnumMember(Value = "SFUN")]
    [IsoId("_X74tYTcVEeiIxKQErQxblg")]
    [Description(@"Legal structure is a structured fund.")]
    StructuredFund = LegalStructureFinancialInstrumentCode.StructuredFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal structure is a structured security.
    /// Encoded/decoded by serializers as "SSEC".
    /// </summary>
    [EnumMember(Value = "SSEC")]
    [IsoId("_YANMsTcVEeiIxKQErQxblg")]
    [Description(@"Legal structure is a structured security.")]
    StructuredSecurity = LegalStructureFinancialInstrumentCode.StructuredSecurity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as "UCIT".
    /// </summary>
    [EnumMember(Value = "UCIT")]
    [IsoId("_YE9w4TcVEeiIxKQErQxblg")]
    [Description(@"Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS).")]
    UCITS = LegalStructureFinancialInstrumentCode.UCITS, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal structure is an exchange traded commodity.
    /// Encoded/decoded by serializers as "EXTC".
    /// </summary>
    [EnumMember(Value = "EXTC")]
    [IsoId("_atb8EYBgEei8Q7I_11BpAQ")]
    [Description(@"Legal structure is an exchange traded commodity.")]
    ExchangeTradedCommodity = LegalStructureFinancialInstrumentCode.ExchangeTradedCommodity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS) money market fund.
    /// Encoded/decoded by serializers as "UCMM".
    /// </summary>
    [EnumMember(Value = "UCMM")]
    [IsoId("_azh9AYBgEei8Q7I_11BpAQ")]
    [Description(@"Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS) money market fund.")]
    UCITSMoneyMarketFund = LegalStructureFinancialInstrumentCode.UCITSMoneyMarketFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Legal structure is a money market fund that is not an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as "NUMM".
    /// </summary>
    [EnumMember(Value = "NUMM")]
    [IsoId("_LZpQ4YvwEeicrr-UkGlMQA")]
    [Description(@"Legal structure is a money market fund that is not an Undertaking for Collective Investment in Transferable Securities (UCITS).")]
    NonUCITSMoneyMarketFund = LegalStructureFinancialInstrumentCode.NonUCITSMoneyMarketFund, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LegalStructureFinancialInstrument1CodeMetadataExtensions
{
    private static readonly LegalStructureFinancialInstrument1CodeDropdownSource _dropdownSource = new LegalStructureFinancialInstrument1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILegalStructureFinancialInstrument1CodeDropdownRow GetMetadata(this LegalStructureFinancialInstrument1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


