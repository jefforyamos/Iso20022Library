﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TelecomServicesLineItem1.  ISO2002 ID# _QFeoF_fDEei89sMSHxl1ew.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Telecom services line item carries detail level telephony billing data. 
/// </summary>
public partial record TelecomServicesLineItem1
{
    #nullable enable
    
    /// <summary>
    /// Contains the start date and time of the phone call.
    /// </summary>
    public IsoISODate? StartDateTime { get; init; } 
    /// <summary>
    /// Describes the period (such as peak or off peak) of the phone call.
    /// </summary>
    public IsoMax35Text? TimePeriod { get; init; } 
    /// <summary>
    /// Duration of phone call expressed in HHMMSS format. 
    /// </summary>
    public IsoISOTime? Duration { get; init; } 
    /// <summary>
    /// Contains the location description for the originator of the telephone call and the number from which the call was made.
    /// </summary>
    public TelecomCallDetails1? CallFrom { get; init; } 
    /// <summary>
    /// Contains the location description for the destination of the telephone call and the number to which the call was made.
    /// </summary>
    public TelecomCallDetails1? CallTo { get; init; } 
    /// <summary>
    /// Contains the amount pertaining to the telephony billing event.
    /// </summary>
    public Amount11[] Charge { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Total of taxes applicable to the billing amount
    /// </summary>
    public Tax33[] TotalTax { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Total amount applicable to the billing event. 
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Description of the telecommunications services line item details
    /// </summary>
    public IsoMax256Text? Description { get; init; } 
    /// <summary>
    /// Additional user-defined data pertaining to the telecommunications services.
    /// </summary>
    public IsoMax350Text? AdditionalData { get; init; } 
    
    #nullable disable
}
