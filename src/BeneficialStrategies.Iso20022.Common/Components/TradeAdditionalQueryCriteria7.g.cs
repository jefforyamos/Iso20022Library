﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeAdditionalQueryCriteria7.  ISO2002 ID# _QWIcTa5pEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Query criteria regarding action type, product classification, venue of execution, asset class, corporate sector nature of counterparty.
/// </summary>
public partial record TradeAdditionalQueryCriteria7
{
    #nullable enable
    
    /// <summary>
    /// Action types allowed as query criteria.
    /// </summary>
    public TransactionOperationType6Code[] ActionType { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates the execution venue of the reported transaction.
    /// </summary>
    public SecuritiesTradeVenueCriteria1Choice_? ExecutionVenue { get; init; } 
    /// <summary>
    /// Indicates the nature of the reporting counterparty (if it is a central counterparty (CCP), a financial counterparty, a non-financial counterparty or another type of counterparty).
    /// </summary>
    public PartyNatureType1Code[] NatureOfCounterparty { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies the corporate sector of the reporting counterparty.
    /// </summary>
    public CorporateSectorCriteria5[] CorporateSector { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
