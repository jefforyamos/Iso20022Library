﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractRegistration2.  ISO2002 ID# _8qFY8NLIEeSdq5yU2aaSNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorized servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
public partial record ContractRegistration2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the registered contract opening.
    /// </summary>
    public required IsoMax35Text ContractRegistrationOpeningIdentification { get; init; } 
    /// <summary>
    /// Priority requested for the opening of the registered contract.
    /// </summary>
    public required Priority2Code Priority { get; init; } 
    /// <summary>
    /// Details of the contract being registered.
    /// </summary>
    public required UnderlyingContract1Choice_ Contract { get; init; } 
    /// <summary>
    /// contract balance on date of contract registration.
    /// </summary>
    public ContractBalance1[] ContractBalance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of the payment schedule provided in the contract.
    /// </summary>
    public PaymentScheduleType1Choice_? PaymentScheduleType { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of a previous contract registration.
    /// </summary>
    public DocumentIdentification22[] PreviousRegistrationIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Further details on the registered contract opening.
    /// </summary>
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    /// <summary>
    /// Documents provided as attachments to the contract registration request.
    /// </summary>
    public DocumentGeneralInformation3[] Attachment { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
