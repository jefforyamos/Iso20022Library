﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NotificationAdviceStatus1Choice.  ISO2002 ID# _Ri1Ctdp-Ed-ak6NoX_4Aeg_-997189670.
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
    /// Provides the status of a notification advice.
    /// </summary>
    [KnownType(typeof(NotificationAdviceStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(NotificationAdviceStatus1Choice.RejectedStatus))]
    [IsoId("_Ri1Ctdp-Ed-ak6NoX_4Aeg_-997189670")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Notification Advice Status 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NotificationAdviceStatus1Choice_
    #else
    public abstract partial class NotificationAdviceStatus1Choice_
    #endif
    {
    }
}
