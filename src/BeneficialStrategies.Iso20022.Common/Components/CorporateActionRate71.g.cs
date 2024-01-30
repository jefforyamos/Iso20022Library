﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionRate71.  ISO2002 ID# _7-tU_UEEEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates related to a corporate action option.
/// </summary>
public partial record CorporateActionRate71
{
    #nullable enable
    
    /// <summary>
    /// Rate proposed in a remarketing of variable rate notes.
    /// </summary>
    public IsoPercentageRate? ProposedRate { get; init; } 
    /// <summary>
    /// Rate of allowed over-subscription.
    /// </summary>
    public IRateAndAmountFormat39Choice? OversubscriptionRate { get; init; } 
    /// <summary>
    /// Requested tax rate that will be withheld by the tax authorities of the jurisdiction of the issuer, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public IRateAndAmountFormat40Choice? RequestedWithholdingTaxRate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Requested rate at which the income will be withheld by the jurisdiction other than the jurisdiction of the issuer’s country of tax incorporation, for which a relief at source and/or reclaim may be possible.
    /// </summary>
    public IRateAndAmountFormat40Choice? RequestedSecondLevelTaxRate { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
