﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentPeriod1.  ISO2002 ID# _RJpGp9p-Ed-ak6NoX_4Aeg_1939135068.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the payment terms by means of a code and a period.
/// </summary>
public partial record PaymentPeriod1
{
    #nullable enable
    
    /// <summary>
    /// Code for the payment.
    /// </summary>
    public required PaymentTime1Code Code { get; init; } 
    /// <summary>
    /// Number of days after which the payment must be effected.
    /// </summary>
    public IsoNumber? NumberOfDays { get; init; } 
    
    #nullable disable
}
