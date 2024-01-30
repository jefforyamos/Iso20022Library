﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractRegistrationStatement2.  ISO2002 ID# _TYk8IW49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement of the journal entries for all activities related to the registered currency control contract.
/// </summary>
public partial record ContractRegistrationStatement2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the contract registration statement.
    /// </summary>
    public IsoMax35Text? StatementIdentification { get; init; } 
    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    public required TradeParty5 ReportingParty { get; init; } 
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    /// <summary>
    /// Specifies the period for which the statement is provided.
    /// </summary>
    public required ReportingPeriod4 ReportingPeriod { get; init; } 
    /// <summary>
    /// Registered currency control contract.
    /// </summary>
    public required RegisteredContract8 RegisteredContract { get; init; } 
    /// <summary>
    /// Journal of the transactions recorded under the registered currency control contract.
    /// </summary>
    public TransactionCertificate3? TransactionJournal { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Journal of the supporting documents recorded under the registered currency control contract.
    /// </summary>
    public SupportingDocument2? SupportingDocumentJournal { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Journal of additional supporting documents recorded under the registered currency control contract.
    /// </summary>
    public SupportingDocument2? AdditionalSupportingDocumentJournal { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Details on the currency control rule against which has been violated.
    /// </summary>
    public GenericValidationRuleIdentification1? RegulatoryRuleValidation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Total turn over amount recorded under the currency control contract for the amount of all.
    /// </summary>
    public required IsoActiveCurrencyAndAmount TotalContractTurnoverSum { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
