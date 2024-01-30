﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentDataSetTransaction1.  ISO2002 ID# _SxR5qAEcEeCQm6a_G2yO_w_1194711550.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction to capture in the batch.
/// </summary>
public partial record CardPaymentDataSetTransaction1
{
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    public Traceability1? Traceability { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data related to the environment of the transaction in a transaction captured in batch.
    /// </summary>
    public required CardPaymentEnvironment6 Environment { get; init; } 
    /// <summary>
    /// Data related to the context of the transaction.
    /// </summary>
    public CardPaymentContext3? Context { get; init; } 
    /// <summary>
    /// Transaction information to be captured.
    /// </summary>
    public required CardPaymentTransaction4 Transaction { get; init; } 
    
    #nullable disable
}
