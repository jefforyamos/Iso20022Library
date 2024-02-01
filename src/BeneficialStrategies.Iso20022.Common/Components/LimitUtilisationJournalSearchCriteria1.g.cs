﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LimitUtilisationJournalSearchCriteria1.  ISO2002 ID# _jOa_4-5NEeCisYr99QEiWA_-1185186372.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for a limit.
/// </summary>
public partial record LimitUtilisationJournalSearchCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Type of limit applied by the system at the present time.
    /// </summary>
    public LimitType4Code[] LimitType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Date upon which journal activity takes place.
    /// </summary>
    public required IsoISODate JournalActivityDate { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification4Choice_? AccountIdentification { get; init; } 
    /// <summary>
    /// Currency unit used to specify the limit amount.
    /// </summary>
    public ActiveCurrencyCode? LimitCurrency { get; init; } 
    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    public IsoBICFIIdentifier? AccountOwner { get; init; } 
    /// <summary>
    /// Identification of the system member for which the limit is established.
    /// </summary>
    public required SystemPartyIdentification4 BilateralLimitCounterpartyIdentification { get; init; } 
    
    #nullable disable
}
