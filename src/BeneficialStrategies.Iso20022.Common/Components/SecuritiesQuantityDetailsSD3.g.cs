﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesQuantityDetailsSD3.  ISO2002 ID# _Hnr6scVJEeeWeZMpNX1JUQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about securities quantity linked to a corporate action option.
/// </summary>
public partial record SecuritiesQuantityDetailsSD3
{
    #nullable enable
    
    /// <summary>
    /// For rights subscription events with an oversubscription feature, the quantity of the oversubscription for the given instruction.
    /// </summary>
    public FinancialInstrumentQuantity4? OversubscriptionQuantity { get; init; } 
    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; } 
    /// <summary>
    /// Instruction quantity for a given transaction sequence number.
    /// </summary>
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; init; } 
    
    #nullable disable
}
