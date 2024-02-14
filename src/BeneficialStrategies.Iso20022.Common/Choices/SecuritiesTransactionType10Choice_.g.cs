﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesTransactionType10Choice.  ISO2002 ID# _PlajS_vmEeCBQp5TnX1XKQ.
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
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType10Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType10Choice.Proprietary))]
    [IsoId("_PlajS_vmEeCBQp5TnX1XKQ")]
    [DisplayName("Securities Transaction Type 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType10Choice_
    #else
    public abstract partial class SecuritiesTransactionType10Choice_
    #endif
    {
    }
}
