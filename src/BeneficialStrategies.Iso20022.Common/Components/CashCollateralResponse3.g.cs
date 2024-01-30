﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashCollateralResponse3.  ISO2002 ID# _2Q43cStIEeyOa655cLd-DQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides more details on the response such as the response type, the collateral identification, and optionally further details in case of rejection.
/// </summary>
public partial record CashCollateralResponse3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of the collateral proposal.
    /// </summary>
    public required Status4Code ResponseType { get; init; } 
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    public IsoMax35Text? CollateralIdentification { get; init; } 
    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    public IsoMax35Text? AssetNumber { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public IAccountIdentification4Choice? CashAccountIdentification { get; init; } 
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    public RejectionReason68Code? RejectionReason { get; init; } 
    /// <summary>
    /// Additional information regarding why the collateral proposal has a rejected status.
    /// </summary>
    public IsoMax35Text? RejectionInformation { get; init; } 
    
    #nullable disable
}
