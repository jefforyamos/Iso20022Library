﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransactionLoanData31Choice.  ISO2002 ID# _lmwk8czsEeux2uvSBFU54Q.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the details of the reported transaction.
    /// </summary>
    [KnownType(typeof(TransactionLoanData31Choice.RepurchaseTrade))]
    [KnownType(typeof(TransactionLoanData31Choice.BuySellBack))]
    [KnownType(typeof(TransactionLoanData31Choice.SecuritiesLending))]
    [KnownType(typeof(TransactionLoanData31Choice.MarginLending))]
    [IsoId("_lmwk8czsEeux2uvSBFU54Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Loan Data 31 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionLoanData31Choice_
    #else
    public abstract partial class TransactionLoanData31Choice_
    #endif
    {
    }
}
