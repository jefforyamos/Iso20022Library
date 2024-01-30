﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferInstruction1.  ISO2002 ID# _AU8gYUz5EeepdbMfWGyv3Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further information required for the account switch.
/// </summary>
public partial record TransferInstruction1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether a payment arrangement is transferable.
    /// Usage: Default value for TransferIndicator is false.
    /// </summary>
    public IsoYesNoIndicator? TransferIndicator { get; init; } 
    /// <summary>
    /// Specifies an additional parameter to be applied to the requested transaction schedule.
    /// </summary>
    public required IsoMax35Text Code { get; init; } 
    /// <summary>
    /// Specifies an additional parameter to be applied to the transaction schedule in a proprietary format.
    /// </summary>
    public IsoMax256Text? Proprietary { get; init; } 
    /// <summary>
    /// The date and time at which the event specified by Code commences.
    /// </summary>
    public IsoISODateTime? StartDateTime { get; init; } 
    /// <summary>
    /// The date on which the event specified by Code commences.
    /// </summary>
    public IsoISODate? StartDate { get; init; } 
    /// <summary>
    /// Additional switch parameters in a free text format.
    /// </summary>
    public IsoMax350Text? Description { get; init; } 
    
    #nullable disable
}
