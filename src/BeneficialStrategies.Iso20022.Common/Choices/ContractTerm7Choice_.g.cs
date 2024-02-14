﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ContractTerm7Choice.  ISO2002 ID# _xcgx0a5qEeuo-IflVgGqiA.
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
    /// Specifies whether the transaction is open term, that is. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
    /// </summary>
    [KnownType(typeof(ContractTerm7Choice.Open))]
    [KnownType(typeof(ContractTerm7Choice.Fixed))]
    [IsoId("_xcgx0a5qEeuo-IflVgGqiA")]
    [DisplayName("Contract Term 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ContractTerm7Choice_
    #else
    public abstract partial class ContractTerm7Choice_
    #endif
    {
    }
}
