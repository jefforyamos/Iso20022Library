﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionQuantity1.  ISO2002 ID# _TZS1ENp-Ed-ak6NoX_4Aeg_-702995284.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action quantities.
/// </summary>
public partial record CorporateActionQuantity1
{
    #nullable enable
    
    /// <summary>
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    public IFinancialInstrumentQuantity1Choice? MinimumExercisableQuantity { get; init; } 
    /// <summary>
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    public IFinancialInstrumentQuantity1Choice? MinimumExercisableMultipleQuantity { get; init; } 
    /// <summary>
    /// Maximum number of securities the offeror is requesting to complete the event.
    /// </summary>
    public IFinancialInstrumentQuantity2Choice? MaximumQuantity { get; init; } 
    /// <summary>
    /// Minimum quantity of securities the offeror/issuer will purchase or redeem under the terms of the event. This can be a number or the term "any and all".
    /// </summary>
    public IFinancialInstrumentQuantity2Choice? MinimumQuantitySought { get; init; } 
    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    public IFinancialInstrumentQuantity1Choice? NewBoardLotQuantity { get; init; } 
    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    public IFinancialInstrumentQuantity1Choice? NewDenominationQuantity { get; init; } 
    /// <summary>
    /// Minimum integral amount of securities that each account owner must have remaining after the called amounts are applied.
    /// </summary>
    public IFinancialInstrumentQuantity1Choice? BaseDenomination { get; init; } 
    /// <summary>
    /// Amount used when the called amount is not met by running the lottery with the base denomination.
    /// </summary>
    public IFinancialInstrumentQuantity1Choice? IncrementalDenomination { get; init; } 
    
    #nullable disable
}
