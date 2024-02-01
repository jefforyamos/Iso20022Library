﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption23.  ISO2002 ID# _4_WVcfmZEeCju-AyqEOrHg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the security option of a corporate event.
/// </summary>
public partial record SecuritiesOption23
{
    #nullable enable
    
    /// <summary>
    /// Maximum quantity (or lot) of financial instrument that may be exercised or tendered.
    /// </summary>
    public FinancialInstrumentQuantity19Choice_? MaximumExercisableQuantity { get; init; } 
    /// <summary>
    /// Minimum quantity (or lot) of financial instrument that may be exercised or tendered.
    /// </summary>
    public FinancialInstrumentQuantity19Choice_? MinimumExercisableQuantity { get; init; } 
    /// <summary>
    /// Minimum multiple quantity (or lot) of financial instrument that may be exercised or tendered.
    /// </summary>
    public FinancialInstrumentQuantity20Choice_? MinimumExercisableMultipleQuantity { get; init; } 
    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    public FinancialInstrumentQuantity20Choice_? NewBoardLotQuantity { get; init; } 
    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    public FinancialInstrumentQuantity20Choice_? NewDenominationQuantity { get; init; } 
    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    public FinancialInstrumentQuantity20Choice_? FrontEndOddLotQuantity { get; init; } 
    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    public FinancialInstrumentQuantity20Choice_? BackEndOddLotQuantity { get; init; } 
    
    #nullable disable
}
