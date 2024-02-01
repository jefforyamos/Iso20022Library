﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeTransactionIdentification6.  ISO2002 ID# _Sm4DUa4ZEemB_csI4yyKLA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on transaction and conducting counterparty.
/// </summary>
public partial record TradeTransactionIdentification6
{
    #nullable enable
    
    /// <summary>
    /// Unique code identifying the reporting counterparty.
    /// </summary>
    public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; } 
    /// <summary>
    /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
    /// </summary>
    public required OrganisationIdentification9Choice_ OtherCounterparty { get; init; } 
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the counterparty.
    /// </summary>
    public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    public MasterAgreement1? MasterAgreement { get; init; } 
    
    #nullable disable
}
