﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ClearingPartyAndTime9.  ISO2002 ID# _HQfLpbQ0EemI67HK7aviyg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the central counterparty clearing time.
/// </summary>
public partial record ClearingPartyAndTime9
{
    #nullable enable
    
    /// <summary>
    /// In the case of a contract that has been cleared, the unique code for the clearing counterparty that has cleared the contract.
    /// </summary>
    public OrganisationIdentification9Choice_? CCP { get; init; } 
    /// <summary>
    /// Time and date when clearing took place.
    /// </summary>
    public IsoISODateTime? ClearingDateTime { get; init; } 
    /// <summary>
    /// Unique number to indicate a group of reports which relate to the same execution.
    /// </summary>
    public IsoMax52Text? ReportTrackingNumber { get; init; } 
    /// <summary>
    /// If the transaction is cleared and is included in a portfolio of transactions for which margins are exchanged, this portfolio should be identified by a unique code determined by the reporting counterparty.
    /// </summary>
    public IsoMax52Text? PortfolioCode { get; init; } 
    
    #nullable disable
}
