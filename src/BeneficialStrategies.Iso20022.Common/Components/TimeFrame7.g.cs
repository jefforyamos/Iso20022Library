﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TimeFrame7.  ISO2002 ID# _FElasbnxEeq5Lv5RTGDs7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time frame elements that define a period as number of days before or after a activity.
/// </summary>
public partial record TimeFrame7
{
    #nullable enable
    
    /// <summary>
    /// Description of the timeframe.
    /// </summary>
    public IsoMax350Text? OtherTimeFrameDescription { get; init; } 
    /// <summary>
    /// Number of days after the trade date (T) used for the standard timeframe for the issue of a deal confirmation.
    /// </summary>
    public IsoNumber? TradePlus { get; init; } 
    /// <summary>
    /// Convention used for adjusting a date when it is not a business day.
    /// </summary>
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; init; } 
    /// <summary>
    /// For the time of the issuance of the deal confirmation, the order desk must be contacted.
    /// </summary>
    public ReferToFundOrderDesk1Code? ReferToOrderDesk { get; init; } 
    
    #nullable disable
}
