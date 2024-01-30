﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument24.  ISO2002 ID# _O9ElUfssEeCUd_EZYqZ_Uw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
public partial record FinancialInstrument24
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required ISecurityIdentification3Choice Identification { get; init; } 
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Specifies whether the financial instrument is transferred as an asset or as cash.
    /// </summary>
    public required TransferType1Code TransferType { get; init; } 
    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    public IQuantity12Choice? Quantity { get; init; } 
    /// <summary>
    /// Average cost per share of a security, including all charges and commissions.
    /// </summary>
    public IsoActiveCurrencyAndAmount? AverageAcquisitionPrice { get; init; } 
    /// <summary>
    /// Net asset on balance sheet - total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; init; } 
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    public Account6? TransfereeAccount { get; init; } 
    
    #nullable disable
}
