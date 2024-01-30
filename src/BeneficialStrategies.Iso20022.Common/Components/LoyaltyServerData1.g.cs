﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyServerData1.  ISO2002 ID# _0ZN1QNxLEeioifFt1dhnJA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the loyalty server during a loyalty transaction.
/// </summary>
public partial record LoyaltyServerData1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the loyalty Server.
    /// </summary>
    public IsoMax35Text? LoyaltyServerIdentification { get; init; } 
    /// <summary>
    /// Approval code assigned to a loyalty transaction by the Server.
    /// </summary>
    public IsoMin6Max8Text? ApprovalCode { get; init; } 
    /// <summary>
    /// Identification of the Loyalty transaction in an unambiguous way.
    /// </summary>
    public TransactionIdentifier1? LoyaltyTransactionIdentification { get; init; } 
    /// <summary>
    /// Identifier of a reconciliation period with a payment or loyalty host.
    /// </summary>
    public IsoMax35Text? HostReconciliationIdentification { get; init; } 
    
    #nullable disable
}
