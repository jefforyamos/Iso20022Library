﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BlockedStatusReason2.  ISO2002 ID# __e0zUV1LEeagR5I1rq5oaw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a blocked status.
/// </summary>
public partial record BlockedStatusReason2
{
    #nullable enable
    
    /// <summary>
    /// Type of transaction for which the account has a blocked status.
    /// </summary>
    public required ITransactionType5Choice TransactionType { get; init; } 
    /// <summary>
    /// Indicates whether the account is blocked.
    /// </summary>
    public required IsoYesNoIndicator Blocked { get; init; } 
    /// <summary>
    /// Reason for the blocked status.
    /// </summary>
    public IBlockedReason2Choice? Reason { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional information about the blocked account status.
    /// </summary>
    public required IsoMax350Text AdditionalInformation { get; init; } 
    
    #nullable disable
}
