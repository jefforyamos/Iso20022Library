﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TelecomServicesSummary1.  ISO2002 ID# _3YH6X_e-Eei89sMSHxl1ew.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Telecom services summary component carries summary level telephony billing data. 
/// </summary>
public partial record TelecomServicesSummary1
{
    #nullable enable
    
    /// <summary>
    /// Contains the details of the customer. Also known as the user of the service.
    /// </summary>
    public Customer6? Customer { get; init; } 
    /// <summary>
    /// Contains the billing period start date for telecommunication or related services.
    /// </summary>
    public IsoISODate? BillingStatementPeriodStart { get; init; } 
    /// <summary>
    /// Contains the billing period end date for telecommunication or related services.
    /// </summary>
    public IsoISODate? BillingStatementPeriodEnd { get; init; } 
    /// <summary>
    /// Summary of the charges associated with the billing event. 
    /// </summary>
    public Amount10? BillingEvent { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Total of taxes applicable to the billing amount.
    /// </summary>
    public Tax33? TotalTax { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional user-defined data pertaining to the shipment.
    /// </summary>
    public IsoMax350Text? AdditionalData { get; init; } 
    
    #nullable disable
}
