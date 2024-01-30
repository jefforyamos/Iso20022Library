﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedAmount21.  ISO2002 ID# _6c6g8QxjEeqEbo60f0v6aw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
public partial record DetailedAmount21
{
    #nullable enable
    
    /// <summary>
    /// Amount value.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Date and time of the payment.
    /// </summary>
    public required IsoISODateTime DateTime { get; init; } 
    /// <summary>
    /// Card data entry mode for the related payment.
    /// </summary>
    public CardDataReading8Code? CardDataEntryMode { get; init; } 
    /// <summary>
    /// Data of an integrated circuit card application for the related payment.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    /// <summary>
    /// Short description of the amount to display or print.
    /// </summary>
    public IsoMax140Text? Label { get; init; } 
    
    #nullable disable
}
