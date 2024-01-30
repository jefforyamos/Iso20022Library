﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AutomatedTellerMachine4.  ISO2002 ID# _c6-zIYqsEeSIDtZ76p6McQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM information.
/// </summary>
public partial record AutomatedTellerMachine4
{
    #nullable enable
    
    /// <summary>
    /// ATM terminal device identification for the acquirer and the issuer.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// ATM terminal device identification for the ATM manager.
    /// </summary>
    public IsoMax35Text? AdditionalIdentification { get; init; } 
    /// <summary>
    /// ATM terminal device identification for the branch.
    /// </summary>
    public IsoMax35Text? SequenceNumber { get; init; } 
    /// <summary>
    /// Reference currency of the ATM.
    /// </summary>
    public required ActiveCurrencyCode BaseCurrency { get; init; } 
    /// <summary>
    /// Location of the ATM.
    /// </summary>
    public PostalAddress17? Location { get; init; } 
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    public TransactionEnvironment2Code? LocationCategory { get; init; } 
    /// <summary>
    /// Capabilities of the ATM terminal performing the transaction.
    /// </summary>
    public PointOfInteractionCapabilities5? Capabilities { get; init; } 
    /// <summary>
    /// ATM terminal equipment.
    /// </summary>
    public ATMEquipment1? Equipment { get; init; } 
    /// <summary>
    /// List of ATM devices out of service.
    /// </summary>
    public ATMDevice2Code? AvailableDevice { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
