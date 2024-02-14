﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SecuritiesTransactionType55Choice.  ISO2002 ID# _qIKqe_fYEeiNZp_PtLohLw.
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
    /// Choice of formats for a repair reason.
    /// </summary>
    [KnownType(typeof(SecuritiesTransactionType55Choice.Code))]
    [KnownType(typeof(SecuritiesTransactionType55Choice.Proprietary))]
    [IsoId("_qIKqe_fYEeiNZp_PtLohLw")]
    [DisplayName("Securities Transaction Type 55 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesTransactionType55Choice_
    #else
    public abstract partial class SecuritiesTransactionType55Choice_
    #endif
    {
    }
}
