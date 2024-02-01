﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FailedSettlement.  ISO2002 ID# _o1CqrRwkEeOIveEnnb_1-A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus1Choice;

/// <summary>
/// Status of the transfer is failed settlement, that is, settlement in the International Central Securities Depository (ICSD) or Central Securities Depository (CSD) failed.
/// </summary>
public partial record FailedSettlement : TransferStatus1Choice_
{
    #nullable enable
    /// <summary>
    /// Reason for the failed settlement status.
    /// </summary>
    public required IsoMax350Text Reason { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason for the failed settlement status.
    /// </summary>
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    #nullable disable
}
