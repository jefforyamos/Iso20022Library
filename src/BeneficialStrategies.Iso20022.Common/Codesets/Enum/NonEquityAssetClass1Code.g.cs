﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NonEquityAssetClass1Code.  ISO2002 ID# _kJOfgIMfEeqqSpeC5JM2Mw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the asset class of a non-equity financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kJOfgIMfEeqqSpeC5JM2Mw")]
[Description(@"Specifies the asset class of a non-equity financial instrument.")]
[DerivedFrom(typeof(NonEquityAssetClassCode))]
public enum NonEquityAssetClass1Code
{
    /// <summary>
    /// Securitised derivative.
    /// Encoded/decoded by serializers as "SDRV".
    /// </summary>
    [EnumMember(Value = "SDRV")]
    [IsoId("_zjcKwYMfEeqqSpeC5JM2Mw")]
    [Description(@"Securitised derivative.")]
    SecuritisedDerivative = NonEquityAssetClassCode.SecuritisedDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest rate derivative.
    /// Encoded/decoded by serializers as "IRDV".
    /// </summary>
    [EnumMember(Value = "IRDV")]
    [IsoId("_znlD4YMfEeqqSpeC5JM2Mw")]
    [Description(@"Interest rate derivative.")]
    InterestRateDerivative = NonEquityAssetClassCode.InterestRateDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Foreign exchange derivative.
    /// Encoded/decoded by serializers as "FEXD".
    /// </summary>
    [EnumMember(Value = "FEXD")]
    [IsoId("_zrxAUYMfEeqqSpeC5JM2Mw")]
    [Description(@"Foreign exchange derivative.")]
    ForeignExchangeDerivative = NonEquityAssetClassCode.ForeignExchangeDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Equity derivative.
    /// Encoded/decoded by serializers as "EQDV".
    /// </summary>
    [EnumMember(Value = "EQDV")]
    [IsoId("_zwV-UYMfEeqqSpeC5JM2Mw")]
    [Description(@"Equity derivative.")]
    EquityDerivative = NonEquityAssetClassCode.EquityDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Emission allowance derivative.
    /// Encoded/decoded by serializers as "EADV".
    /// </summary>
    [EnumMember(Value = "EADV")]
    [IsoId("_z0EAsYMfEeqqSpeC5JM2Mw")]
    [Description(@"Emission allowance derivative.")]
    EmissionAllowanceDerivative = NonEquityAssetClassCode.EmissionAllowanceDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Emission allowance.
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_z3jZkYMfEeqqSpeC5JM2Mw")]
    [Description(@"Emission allowance.")]
    EmissionAllowance = NonEquityAssetClassCode.EmissionAllowance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit derivative.
    /// Encoded/decoded by serializers as "CRDV".
    /// </summary>
    [EnumMember(Value = "CRDV")]
    [IsoId("_z8F7UYMfEeqqSpeC5JM2Mw")]
    [Description(@"Credit derivative.")]
    CreditDerivative = NonEquityAssetClassCode.CreditDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract for difference.
    /// Encoded/decoded by serializers as "CFDS".
    /// </summary>
    [EnumMember(Value = "CFDS")]
    [IsoId("_0AIGwYMfEeqqSpeC5JM2Mw")]
    [Description(@"Contract for difference.")]
    ContractForDifference = NonEquityAssetClassCode.ContractForDifference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity derivative.
    /// Encoded/decoded by serializers as "COMD".
    /// </summary>
    [EnumMember(Value = "COMD")]
    [IsoId("_0Er2oYMfEeqqSpeC5JM2Mw")]
    [Description(@"Commodity derivative.")]
    CommodityDerivative = NonEquityAssetClassCode.CommodityDerivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// C10 derivative.
    /// Encoded/decoded by serializers as "C10D".
    /// </summary>
    [EnumMember(Value = "C10D")]
    [IsoId("_0Jp2MYMfEeqqSpeC5JM2Mw")]
    [Description(@"C10 derivative.")]
    C10Derivative = NonEquityAssetClassCode.C10Derivative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bond.
    /// Encoded/decoded by serializers as "BOND".
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_fefhgYSaEequddKuwPSZfQ")]
    [Description(@"Bond.")]
    Bond = NonEquityAssetClassCode.Bond, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange traded commodities.
    /// Encoded/decoded by serializers as "ETCS".
    /// </summary>
    [EnumMember(Value = "ETCS")]
    [IsoId("_flC1cYSaEequddKuwPSZfQ")]
    [Description(@"Exchange traded commodities.")]
    ExchangeTradedCommodities = NonEquityAssetClassCode.ExchangeTradedCommodities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange traded note.
    /// Encoded/decoded by serializers as "ETNS".
    /// </summary>
    [EnumMember(Value = "ETNS")]
    [IsoId("_fsL_QYSaEequddKuwPSZfQ")]
    [Description(@"Exchange traded note.")]
    ExchangeTradedNote = NonEquityAssetClassCode.ExchangeTradedNote, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Structured finance product.
    /// Encoded/decoded by serializers as "SFPS".
    /// </summary>
    [EnumMember(Value = "SFPS")]
    [IsoId("_gBDcAYSaEequddKuwPSZfQ")]
    [Description(@"Structured finance product.")]
    StructuredFinanceProduct = NonEquityAssetClassCode.StructuredFinanceProduct, // same ordinal as derivation source for type conversions
    
}
