﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ReversalReason1Choice.  ISO2002 ID# _TPTyo9p-Ed-ak6NoX_4Aeg_672866376.
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
    /// Reason for the reversal of the transaction.
    /// </summary>
    [KnownType(typeof(ReversalReason1Choice.Code))]
    [KnownType(typeof(ReversalReason1Choice.Proprietary))]
    [IsoId("_TPTyo9p-Ed-ak6NoX_4Aeg_672866376")]
    [DisplayName("Reversal Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReversalReason1Choice_
    #else
    public abstract partial class ReversalReason1Choice_
    #endif
    {
    }
}
