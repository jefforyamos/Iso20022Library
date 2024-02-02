﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractRegistration1.  ISO2002 ID# _wrdDwNLIEeSdq5yU2aaSNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Currency control contract registration details.
/// </summary>
[DataContract]
[XmlType]
public partial record ContractRegistration1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the contract registration.
    /// </summary>
    [DataMember]
    public required IsoMax35Text ContractRegistrationIdentification { get; init; } 
    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [DataMember]
    public required TradeParty2 ReportingParty { get; init; } 
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [DataMember]
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; } 
    /// <summary>
    /// Details about the opening of the contract registration.
    /// </summary>
    [DataMember]
    public ValueList<ContractRegistration2> ContractRegistrationOpening { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [DataMember]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
