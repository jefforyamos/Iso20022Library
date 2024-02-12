﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TransactionType5Choice.  ISO2002 ID# _x6jKoVsJEea4y99eritluQ.
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
    /// Choice of formats for the specification of the order type.
    /// </summary>
    [KnownType(typeof(TransactionType5Choice.Code))]
    [KnownType(typeof(TransactionType5Choice.Proprietary))]
    [IsoId("_x6jKoVsJEea4y99eritluQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Type 5 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionType5Choice_
    #else
    public abstract partial class TransactionType5Choice_
    #endif
    {
    }
}
