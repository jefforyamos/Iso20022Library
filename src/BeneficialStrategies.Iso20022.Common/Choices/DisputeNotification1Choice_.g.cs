﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DisputeNotification1Choice.  ISO2002 ID# _QmU-Mtp-Ed-ak6NoX_4Aeg_2020917030.
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
    /// Provides the dispute notification details for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(DisputeNotification1Choice.DisputeNotificationDetails))]
    [KnownType(typeof(DisputeNotification1Choice.SegregatedIndependentAmountDisputeDetails))]
    [IsoId("_QmU-Mtp-Ed-ak6NoX_4Aeg_2020917030")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Dispute Notification 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DisputeNotification1Choice_
    #else
    public abstract partial class DisputeNotification1Choice_
    #endif
    {
    }
}
