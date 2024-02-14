﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for EventProcessingStatus6Choice.  ISO2002 ID# _Szi6OgVREeqjd8n6wD9JVw.
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
    /// Provides information about the status of a corporate action or the status of a payment.
    /// </summary>
    [KnownType(typeof(EventProcessingStatus6Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus6Choice.Reconciled))]
    [KnownType(typeof(EventProcessingStatus6Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus6Choice.ProprietaryStatus))]
    [IsoId("_Szi6OgVREeqjd8n6wD9JVw")]
    [DisplayName("Event Processing Status 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EventProcessingStatus6Choice_
    #else
    public abstract partial class EventProcessingStatus6Choice_
    #endif
    {
    }
}
