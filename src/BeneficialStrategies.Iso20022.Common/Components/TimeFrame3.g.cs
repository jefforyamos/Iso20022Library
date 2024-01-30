﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TimeFrame3.  ISO2002 ID# _UAoh4Np-Ed-ak6NoX_4Aeg_-1899090252.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// TimeFrame elements that define a period as number of days before or after a activity.
/// </summary>
public partial record TimeFrame3
{
    #nullable enable
    
    /// <summary>
    /// Specifies a description of any other TimeFrame that may be used for the DealingCutOffTimeFrame.
    /// </summary>
    public IsoMax350Text? OtherTimeFrameDescription { get; init; } 
    /// <summary>
    /// An agreed number of days before the Trade date (T) used to define standard timeframes e.g. T-1 Dealing cut off or T-2 prepayment condition||Where = T is the date that the price is applied to a transaction.
    /// </summary>
    public IsoNumber? TradeMinus { get; init; } 
    /// <summary>
    /// Convention used for adjusting a date when it is not a business day.
    /// </summary>
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; init; } 
    /// <summary>
    /// Refer to Order Desk.
    /// </summary>
    public ReferToFundOrderDesk1Code? ReferToOrderDesk { get; init; } 
    
    #nullable disable
}
