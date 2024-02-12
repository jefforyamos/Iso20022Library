﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcceptedReason1Choice.  ISO2002 ID# _QyjcV9p-Ed-ak6NoX_4Aeg_831638355.
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
    /// Choice between a standard code or proprietary code to specify the reason why the instruction or cancellation request has a accepted status.
    /// </summary>
    [KnownType(typeof(AcceptedReason1Choice.Code))]
    [KnownType(typeof(AcceptedReason1Choice.Proprietary))]
    [IsoId("_QyjcV9p-Ed-ak6NoX_4Aeg_831638355")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Accepted Reason 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcceptedReason1Choice_
    #else
    public abstract partial class AcceptedReason1Choice_
    #endif
    {
    }
}
