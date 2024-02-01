﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSetTransaction25.  ISO2002 ID# _eun4sdtQEee9e6xduATmQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment transaction including an authorisation response.
/// </summary>
public partial record CardPaymentDataSetTransaction25
{
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    public Traceability5[] Traceability { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Data related to the environment of the card payment transaction.
    /// </summary>
    public required CardPaymentEnvironment69 Environment { get; init; } 
    /// <summary>
    /// Card payment transaction authorisation result.
    /// </summary>
    public required CardPaymentTransaction78 Transaction { get; init; } 
    /// <summary>
    /// Response to the authorisation request from the acquirer.
    /// </summary>
    public required CardPaymentTransaction84 TransactionResponse { get; init; } 
    
    #nullable disable
}
