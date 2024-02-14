﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ElectionAdviceStatus1Choice.  ISO2002 ID# _RiYWxtp-Ed-ak6NoX_4Aeg_896505165.
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
    /// Choice between the different statuses of an election advice.
    /// </summary>
    [KnownType(typeof(ElectionAdviceStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(ElectionAdviceStatus1Choice.RejectedStatus))]
    [IsoId("_RiYWxtp-Ed-ak6NoX_4Aeg_896505165")]
    [DisplayName("Election Advice Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ElectionAdviceStatus1Choice_
    #else
    public abstract partial class ElectionAdviceStatus1Choice_
    #endif
    {
    }
}
