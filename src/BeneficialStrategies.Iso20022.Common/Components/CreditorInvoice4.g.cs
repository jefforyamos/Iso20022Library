﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditorInvoice4.  ISO2002 ID# _zyspBeH5Eeqbls7Gk4-ckA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the identification attribtues of an invoice which are required by the creditor for the activation of the debtor.
/// </summary>
public partial record CreditorInvoice4
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the creditor allows limited presentment of the e-invoice, that is, only the e-invoice data needed for payment initiation.
    /// When absent, the element is not applicable.
    /// </summary>
    public IsoTrueFalseIndicator? LimitedPresentmentIndicator { get; init; } 
    /// <summary>
    /// Unique and unambiguous type of the identification of the debtor required by the creditor, for example  the reference number or customer number. Unique identification provided by the web bank or web payment services user, with which the creditor may identify the debtor in its system.
    /// </summary>
    public CustomerTypeRequest2? CustomerIdentificationType { get; init; } 
    /// <summary>
    /// Document format type supported to exchange the contracts.
    /// </summary>
    public DocumentFormat2Choice_[] ContractFormatType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Type of the contract reference requested by the creditor which the debtor must provide in the debtor activation request  to identify the contract(s) for which the RTP is requested.
    /// </summary>
    public DocumentType1Choice_[] ContractReferenceType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Instructions provided by the seller (that is creditor or ultimate creditor) for the Request-To-Pay (RTP) recipient (that is the debtor). The instructions may include for example the time required by the creditor to take into account the activation request. The debtor agent may display the information in the customer’s own service language.
    /// </summary>
    public IsoMax500Text? CreditorInstruction { get; init; } 
    /// <summary>
    /// Creditor's service provider address to which the debtor activation has to be delivered.
    /// </summary>
    public RTPPartyIdentification1? ActivationRequestDeliveryParty { get; init; } 
    
    #nullable disable
}
