﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reversed.  ISO2002 ID# _o1CqrxwkEeOIveEnnb_1-A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice;

/// <summary>
/// Status of the transfer is reversed.
/// </summary>
public partial record Reversed : TransferStatus1Choice_
{
    #nullable enable
    /// <summary>
    /// Reason for the reversal status.
    /// </summary>
    public required IsoMax350Text Reason { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason for the reversed status.
    /// </summary>
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #nullable disable
}
