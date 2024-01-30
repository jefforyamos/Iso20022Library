﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransactionIdentification18.  ISO2002 ID# _O3OZgcgsEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on transaction and conducting counterparty.
/// </summary>
public partial record TradeTransactionIdentification18
{
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    public required IOrganisationIdentification15Choice ReportingCounterparty { get; init; } 
    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    public required IPartyIdentification236Choice OtherCounterparty { get; init; } 
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the counterparty.
    /// </summary>
    public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    public MasterAgreement7? MasterAgreement { get; init; } 
    
    #nullable disable
}
