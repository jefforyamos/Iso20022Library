﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentBatchTransfer3.  ISO2002 ID# _NvxRsWmFEeS7iYydEtv3Ug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment transactions from one or several data set of transactions.
/// </summary>
public partial record CardPaymentBatchTransfer3
{
    #nullable enable
    
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    public TransactionTotals3? TransactionTotals { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Card payment transactions from one data set of transactions.
    /// </summary>
    public CardPaymentDataSet10? DataSet { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
