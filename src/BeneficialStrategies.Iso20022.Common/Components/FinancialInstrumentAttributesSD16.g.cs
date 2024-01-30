﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributesSD16.  ISO2002 ID# _FkrDAb5XEeexmbB7KsjCwA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement security details.
/// </summary>
public partial record FinancialInstrumentAttributesSD16
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    public IsoMax350Text? PlaceAndName { get; init; } 
    /// <summary>
    /// Indicates whether or not the newly issued securities are transferable by the agent. This flag is specific to DTC (The Depository Trust Corporation).
    /// </summary>
    public IsoYesNoIndicator? DTCSecurityTransferableFlag { get; init; } 
    /// <summary>
    /// Details of security that is being distributed as a result of a corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    public FinancialInstrumentAttributesSD18? DeclaredDisbursedSecurityDetails { get; init; } 
    /// <summary>
    /// Further classification of DTC disbursed security instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    public DTCAssetType3Code? DTCDisbursedSecurityAssetType { get; init; } 
    /// <summary>
    /// Classification of DTC disbursed security instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    public AssetClass1Code? DTCDisbursedSecurityAssetClass { get; init; } 
    /// <summary>
    /// Dollar amount attributed to the bond when the par value is less than 1000.
    /// </summary>
    public IsoDecimalNumber? BabyBondDenomination { get; init; } 
    
    #nullable disable
}
