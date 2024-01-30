﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementSubTotalCalculatedTax2.  ISO2002 ID# _sGUvgKtnEeSPCbFcs9Ilyw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the subtotal calculated tax applicable for this settlement.
/// </summary>
public partial record SettlementSubTotalCalculatedTax2
{
    #nullable enable
    
    /// <summary>
    /// Type of tax applied.
    /// </summary>
    public IsoMax4Text? TypeCode { get; init; } 
    /// <summary>
    /// Rate used to calculate the amount of this tax, levy or duty.
    /// </summary>
    public IsoPercentageRate? CalculatedRate { get; init; } 
    /// <summary>
    /// Monetary value used as the basis on which this tax, levy or duty is calculated.
    /// </summary>
    public IsoCurrencyAndAmount? BasisAmount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Monetary value resulting from the calculation of this tax, levy or duty.
    /// </summary>
    public IsoCurrencyAndAmount? CalculatedAmount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Reason for tax exemption expressed as a code, if invoice or card transaction is out of tax processing.
    /// </summary>
    public IsoMax4Text? ExemptionReasonCode { get; init; } 
    /// <summary>
    /// Reason for a tax exemption, if invoice or card transaction is out of tax processing.
    /// </summary>
    public IsoMax500Text? ExemptionReasonText { get; init; } 
    /// <summary>
    /// If tax currency in tax calculation is different from invoice currency, then applied exchange rate is given in this message structure.
    /// </summary>
    public CurrencyReference3? TaxCurrencyExchange { get; init; } 
    
    #nullable disable
}
