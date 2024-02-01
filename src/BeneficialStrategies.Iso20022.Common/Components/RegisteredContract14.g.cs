﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegisteredContract14.  ISO2002 ID# _PYcRcbGJEeuSTr8k0UEM8A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
public partial record RegisteredContract14
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the registered contract amendment request.
    /// </summary>
    public required IsoMax35Text RegisteredContractAmendmentIdentification { get; init; } 
    /// <summary>
    /// Identification of the original contract registration, as registered with the registration agent.
    /// </summary>
    public required IsoMax35Text OriginalRegisteredContractIdentification { get; init; } 
    /// <summary>
    /// Priority requested for the amendment of the registered contract.
    /// </summary>
    public required Priority2Code Priority { get; init; } 
    /// <summary>
    /// Amendment details of the registered contract for the registered contract.
    /// </summary>
    public required UnderlyingContract3Choice_ Contract { get; init; } 
    /// <summary>
    /// Contract balance on date of contract registration.
    /// </summary>
    public ContractBalance1[] ContractBalance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of the payment schedule provided in the contract.
    /// </summary>
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; init; } 
    /// <summary>
    /// Further additional information on the amendment.
    /// </summary>
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Documents provided as attachments to the contract registration amendment request.
    /// </summary>
    public DocumentGeneralInformation5[] Attachment { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
