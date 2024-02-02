﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentBatchTransfer10.  ISO2002 ID# _-xhWAU0ZEeybj420QgWBkA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment transactions from one or several data set of transactions.
/// </summary>
[DataContract]
[XmlType]
public partial record CardPaymentBatchTransfer10
{
    #nullable enable
    
    /// <summary>
    /// Totals of transactions of all the data sets.
    /// </summary>
    [DataMember]
    public ValueList<TransactionTotals12> TransactionTotals { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Card payment transactions from one data set of transactions.
    /// </summary>
    [DataMember]
    public ValueList<CardPaymentDataSet29> DataSet { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
