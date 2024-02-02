﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractRegistrationStatement3.  ISO2002 ID# _W1hHAbGJEeuSTr8k0UEM8A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement of the journal entries for all activities related to the registered currency control contract.
/// </summary>
[DataContract]
[XmlType]
public partial record ContractRegistrationStatement3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the contract registration statement.
    /// </summary>
    [DataMember]
    public IsoMax35Text? StatementIdentification { get; init; } 
    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [DataMember]
    public required TradeParty5 ReportingParty { get; init; } 
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [DataMember]
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    /// <summary>
    /// Specifies the period for which the statement is provided.
    /// </summary>
    [DataMember]
    public required ReportingPeriod4 ReportingPeriod { get; init; } 
    /// <summary>
    /// Registered currency control contract.
    /// </summary>
    [DataMember]
    public required RegisteredContract12 RegisteredContract { get; init; } 
    /// <summary>
    /// Journal of the transactions recorded under the registered currency control contract.
    /// </summary>
    [DataMember]
    public ValueList<TransactionCertificate4> TransactionJournal { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Journal of the supporting documents recorded under the registered currency control contract.
    /// </summary>
    [DataMember]
    public ValueList<SupportingDocument3> SupportingDocumentJournal { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Journal of additional supporting documents recorded under the registered currency control contract.
    /// </summary>
    [DataMember]
    public ValueList<SupportingDocument3> AdditionalSupportingDocumentJournal { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Details on the currency control rule against which has been violated.
    /// </summary>
    [DataMember]
    public ValueList<GenericValidationRuleIdentification1> RegulatoryRuleValidation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Total turn over amount recorded under the currency control contract for the amount of all.
    /// </summary>
    [DataMember]
    public required IsoActiveCurrencyAndAmount TotalContractTurnoverSum { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
