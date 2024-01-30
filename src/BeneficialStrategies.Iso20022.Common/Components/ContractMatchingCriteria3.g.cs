﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractMatchingCriteria3.  ISO2002 ID# _cL1LmVovEe23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compares information related to both sides of a contract.
/// </summary>
public partial record ContractMatchingCriteria3
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the ISINs are matching or not.
    /// </summary>
    public CompareISINIdentifier2? ISIN { get; init; } 
    /// <summary>
    /// Specifies whether the information on the Unique Product Identifiers are matching or not.
    /// </summary>
    public CompareUniqueProductIdentifier2? UniqueProductIdentifier { get; init; } 
    /// <summary>
    /// Specifies whether the information on the AIIs are matching or not.
    /// </summary>
    public CompareText1? AlternativeInstrumentIdentification { get; init; } 
    /// <summary>
    /// Specifies whether the values defined as CFI (Classification of Financial Instruments-ISO 10962) identifier are matching or not.
    /// </summary>
    public CompareCFIIdentifier3? ProductClassification { get; init; } 
    /// <summary>
    /// Specifies whether the information on the contract types are matching or not.
    /// </summary>
    public CompareFinancialInstrumentContractType1? ContractType { get; init; } 
    /// <summary>
    /// Specifies whether the information on the asset classes are matching or not.
    /// </summary>
    public CompareAssetClass1? AssetClass { get; init; } 
    /// <summary>
    /// Specifies whether the information on the derivatives based on crypto assets are matching or not.
    /// </summary>
    public CompareTrueFalseIndicator3? DerivativeBasedOnCryptoAsset { get; init; } 
    /// <summary>
    /// Specifies whether the information on the underlying instruments are matching or not.
    /// </summary>
    public CompareUnderlyingInstrument3? UnderlyingInstrument { get; init; } 
    /// <summary>
    /// Specifies whether the information on the settlement currency are matching or not.
    /// </summary>
    public CompareActiveOrHistoricCurrencyCode1? SettlementCurrency { get; init; } 
    /// <summary>
    /// Specifies whether the information on the settlement currency second legs are matching or not.
    /// </summary>
    public CompareActiveOrHistoricCurrencyCode1? SettlementCurrencySecondLeg { get; init; } 
    
    #nullable disable
}
