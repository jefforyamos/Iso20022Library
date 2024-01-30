﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractValuationData2.  ISO2002 ID# _rIFrmUDWEeWOL-OsSq2h6w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract valuation.
/// </summary>
public partial record ContractValuationData2
{
    #nullable enable
    
    /// <summary>
    /// Mark to market valuation of the contract, or mark to model valuation. The CCP’s valuation to be used for a cleared trade.
    /// </summary>
    public required AmountAndDirection54 ContractValue { get; init; } 
    /// <summary>
    /// Date and time of the last valuation.
    /// Usage: For mark-to-market valuation the date and time of publishing of reference prices shall be reported.
    /// </summary>
    public required IsoISODateTime TimeStamp { get; init; } 
    /// <summary>
    /// Indicate whether valuation was performed mark to market, mark to model or provided by the CCP.
    /// </summary>
    public required ValuationType1Code Type { get; init; } 
    
    #nullable disable
}
