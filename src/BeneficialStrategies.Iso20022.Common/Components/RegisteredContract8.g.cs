﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegisteredContract8.  ISO2002 ID# _TitIl249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
public partial record RegisteredContract8
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the contract registration creation, amendment or closure request.
    /// </summary>
    public IsoMax35Text? OriginalContractRegistrationRequest { get; init; } 
    /// <summary>
    /// Financial institution of the issuer of the contract.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 IssuerFinancialInstitution { get; init; } 
    /// <summary>
    /// Details of the contract being registered.
    /// </summary>
    public required UnderlyingContract2Choice_ Contract { get; init; } 
    /// <summary>
    /// Contract balance on date of contract registration.
    /// </summary>
    public ContractBalance1[] ContractBalance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of the payment schedule provided in the contract.
    /// </summary>
    public PaymentScheduleType1Choice_? PaymentScheduleType { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the registered contract as assigned by the registration agent.
    /// </summary>
    public required DocumentIdentification29 RegisteredContractIdentification { get; init; } 
    /// <summary>
    /// Identification of a previously defined registered contract linked to the same underlying contract.
    /// Usage:
    /// This is the identification of a previous contract registration for the same underlying contract, which was closed. In most cases, this is used when a reporting party moves from one registration agent to another.
    /// </summary>
    public DocumentIdentification22? PreviousRegisteredContractIdentification { get; init; } 
    /// <summary>
    /// Journal of previously closed registered contracts for the same underlying contract, which were requested at the same registration agent.
    /// </summary>
    public RegisteredContractJournal2[] RegisteredContractJournal { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Details on amendments to the registered contract.
    /// </summary>
    public RegisteredContractAmendment1[] Amendment { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides the communication method for the submission of the registered contract.
    /// </summary>
    public required RegisteredContractCommunication1 Submission { get; init; } 
    /// <summary>
    /// Provides the communication method for the delivery of the registered contract.
    /// </summary>
    public required RegisteredContractCommunication1 Delivery { get; init; } 
    /// <summary>
    /// Amount of money the borrower pays back to the lender outside of interests and charges.
    /// Usage:
    /// Only applicable for loan contracts.
    /// </summary>
    public IsoActiveCurrencyAndAmount? LoanPrincipalAmount { get; init; } 
    /// <summary>
    /// Indicates whether the dates provided are estimates or not.
    /// </summary>
    public required IsoTrueFalseIndicator EstimatedDateIndicator { get; init; } 
    /// <summary>
    /// Indicates whether loan in which both the lender and the borrower are divisions of the same corporation or not.
    /// Usage:
    /// Only applicable for loan contracts.
    /// </summary>
    public required IsoTrueFalseIndicator InterCompanyLoan { get; init; } 
    /// <summary>
    /// Further information on the registered contract.
    /// </summary>
    public IsoMax1025Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
