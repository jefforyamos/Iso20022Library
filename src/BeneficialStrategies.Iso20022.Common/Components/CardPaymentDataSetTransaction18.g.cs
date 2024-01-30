﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSetTransaction18.  ISO2002 ID# _gDVTIap2EeanIZ10Ka8PnA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Completed card payment transaction to be captured in batch.
/// </summary>
public partial record CardPaymentDataSetTransaction18
{
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    public Traceability5? Traceability { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data related to the environment of the transaction in a transaction captured in batch.
    /// </summary>
    public required CardPaymentEnvironment61 Environment { get; init; } 
    /// <summary>
    /// Data related to the context of the transaction.
    /// </summary>
    public CardPaymentContext24? Context { get; init; } 
    /// <summary>
    /// Transaction information to be captured.
    /// </summary>
    public required CardPaymentTransaction70 Transaction { get; init; } 
    
    #nullable disable
}
