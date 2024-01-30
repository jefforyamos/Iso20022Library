﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancingInformationAndStatus1.  ISO2002 ID# _RYGZYtp-Ed-ak6NoX_4Aeg_645590457.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financing information and status.
/// </summary>
public partial record FinancingInformationAndStatus1
{
    #nullable enable
    
    /// <summary>
    /// Specifies summary information about invoices/instalments financed, such as total amount financed, number of single requests accepted.
    /// </summary>
    public required FinancingAllowedSummary1 FinancingAllowedSummary { get; init; } 
    /// <summary>
    /// Specifies detailed information about single invoice/instalment financing result, such as result of request (financed or not financed), amount, percentage applied.
    /// </summary>
    public InvoiceFinancingDetails1? InvoiceFinancingDetails { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
