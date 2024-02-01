﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardTransactionDetail4.  ISO2002 ID# _nUP88YNtEeSXtJ8rlirVJw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the card transaction.
/// </summary>
public partial record CardTransactionDetail4
{
    #nullable enable
    
    /// <summary>
    /// Amounts of the transaction expressed within the terminal currency.
    /// </summary>
    public required CardTransactionAmount4 TransactionAmounts { get; init; } 
    /// <summary>
    /// Fees between acquirer and issuer exclusive of the transaction amount, and expressed in the currency of the reconciliation.
    /// </summary>
    public DetailedAmount11[] TransactionFees { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Additional amounts from the processor or the issuer without financial impacts on the transaction amount.
    /// </summary>
    public DetailedAmount10[] AdditionalAmounts { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Account involved in the card transaction.
    /// </summary>
    public CardAccount2[] AccountAndBalance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Results of the verifications performed by the various agents during the processing of the transaction.
    /// </summary>
    public TransactionVerificationResult4[] TransactionVerificationResult { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// It corresponds to ISO 8583, field number 57 for the version 93, and 3 for the version 2003.
    /// </summary>
    public IsoISODate? ValidityDate { get; init; } 
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// It corresponds to ISO 8583, field number 55 for the versions 93 and 2003.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    #nullable disable
}
