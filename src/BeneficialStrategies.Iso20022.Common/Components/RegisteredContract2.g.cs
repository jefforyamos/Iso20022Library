﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegisteredContract2.  ISO2002 ID# _kbGu1dL8EeSDLevdaFPXHw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorized servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
public partial record RegisteredContract2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the registered contract closure.
    /// </summary>
    public required IsoMax35Text RegisteredContractClosureIdentification { get; init; } 
    /// <summary>
    /// Party who registered the currency control contract.
    /// </summary>
    public required TradeParty2 ReportingParty { get; init; } 
    /// <summary>
    /// Agent who registered the currency control contract.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; } 
    /// <summary>
    /// Original registered contract identification.
    /// </summary>
    public required DocumentIdentification29 OriginalRegisteredContract { get; init; } 
    /// <summary>
    /// Priority of the registered contract closure.
    /// </summary>
    public required Priority2Code Priority { get; init; } 
    /// <summary>
    /// Reason of the closure.
    /// </summary>
    public required IContractClosureReason1Choice ClosureReason { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
