﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ReversalReason4Choice.  ISO2002 ID# _TQ8xYNp-Ed-ak6NoX_4Aeg_-340627899.
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
    /// Specifies the reason for the reversal of the transaction.
    /// </summary>
    [KnownType(typeof(ReversalReason4Choice.Code))]
    [KnownType(typeof(ReversalReason4Choice.Proprietary))]
    [IsoId("_TQ8xYNp-Ed-ak6NoX_4Aeg_-340627899")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reversal Reason 4 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReversalReason4Choice_
    #else
    public abstract partial class ReversalReason4Choice_
    #endif
    {
    }
}
