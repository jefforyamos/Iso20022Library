﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountSubLevel22.  ISO2002 ID# _Mhe_8_NyEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed ownership information about the shareholding quantity to be disclosed,  or the shareholding quantity not to be disclosed and the shareholding quantity below threshold.
/// </summary>
public partial record AccountSubLevel22
{
    #nullable enable
    
    /// <summary>
    /// Quantity of shares for which shareholding details are not disclosed.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? NonDisclosedShareholdingQuantity { get; init; } 
    /// <summary>
    /// Quantity of shares for which shareholding details are not reported as the quantity of shares owned by the shareholder is under the threshold limit.
    /// </summary>
    public IFinancialInstrumentQuantity18Choice? BelowThresholdShareholdingQuantity { get; init; } 
    /// <summary>
    /// Details of the account sub-levels and holdings.
    /// </summary>
    public AccountSubLevel23? Disclosure { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
