﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesTransactionPrice14Choice.  ISO2002 ID# _MwrRwQVJEequL9Y8-ASIxA.
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
    /// Choice to define the price of the securities transaction.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionPrice14Choice.Rate))]
    [KnownType(typeof(SecuritiesTransactionPrice14Choice.Decimal))]
    [IsoId("_MwrRwQVJEequL9Y8-ASIxA")]
    [DisplayName("Securities Transaction Price 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionPrice14Choice_
    #else
    public abstract partial class SecuritiesTransactionPrice14Choice_
    #endif
    {
    }
}
