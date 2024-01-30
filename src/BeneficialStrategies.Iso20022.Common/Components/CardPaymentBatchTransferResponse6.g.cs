﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentBatchTransferResponse6.  ISO2002 ID# _vC84QdtPEee9e6xduATmQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status of the transactions sent in a previous batch of card payment transactions.
/// </summary>
public partial record CardPaymentBatchTransferResponse6
{
    #nullable enable
    
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    public TransactionTotals7? TransactionTotals { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information related to the previously sent set of transaction.
    /// </summary>
    public CardPaymentDataSet21? DataSet { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
