﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DuplicateOf.  ISO2002 ID# _T-P8R9p-Ed-ak6NoX_4Aeg_523813131.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus2Choice;

/// <summary>
/// Indicates a duplicated case. |Usage: When present, the case identified in the message must be closed. The case identified as duplicated (in this component) will be pursued.
/// </summary>
public partial record DuplicateOf : IInvestigationStatus2Choice
{
    #nullable enable
    /// <summary>
    /// Uniquely identifies the case.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Party that created the investigation case.
    /// </summary>
    public required IParty7Choice Creator { get; init; } 
    /// <summary>
    /// Indicates whether or not the case was previously closed and is now re-opened.
    /// </summary>
    public IsoYesNoIndicator? ReopenCaseIndication { get; init; } 
    #nullable disable
}
