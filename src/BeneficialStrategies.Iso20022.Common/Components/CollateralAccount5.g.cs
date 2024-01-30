﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralAccount5.  ISO2002 ID# _hcja4XYAEee_qcLXasnA4g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Operational construct used by a central counterparty to record ownership of assets posted as collateral by clearing members to meet their obligations at the central counterparty.
/// </summary>
public partial record CollateralAccount5
{
    #nullable enable
    
    /// <summary>
    /// Unique identifer for the collateral account.
    /// </summary>
    public required IPartyIdentification118Choice Identification { get; init; } 
    /// <summary>
    /// Operational construct used to record the set of positions whose margin requirements is calculated on a gross basis.
    /// </summary>
    public MarginAccount1? RelatedMarginAccount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates whether the account can be used for clients of UK FCA authorised firms subject to Title Transfer Collateral Arrangements (TTCA).
    /// </summary>
    public IsoTrueFalseIndicator? TitleTransferCollateralArrangement { get; init; } 
    /// <summary>
    /// Indicates whether the client collateral is segregated by value in accordance with local regulations. Usage: In the context of clearing members with US clients, in accordance with Section 4d(a)(2) of the Commodity Exchange Act.
    /// </summary>
    public IsoTrueFalseIndicator? CollateralSegregationByValue { get; init; } 
    
    #nullable disable
}
