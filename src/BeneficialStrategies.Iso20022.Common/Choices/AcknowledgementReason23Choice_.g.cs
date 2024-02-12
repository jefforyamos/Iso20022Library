﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AcknowledgementReason23Choice.  ISO2002 ID# _MNvhAekHEemm4qhb2yFPOw.
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
    /// Choice of format for a acknowledgement reason.
    /// </summary>
    [KnownType(typeof(AcknowledgementReason23Choice.Code))]
    [KnownType(typeof(AcknowledgementReason23Choice.Proprietary))]
    [IsoId("_MNvhAekHEemm4qhb2yFPOw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acknowledgement Reason 23 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AcknowledgementReason23Choice_
    #else
    public abstract partial class AcknowledgementReason23Choice_
    #endif
    {
    }
}
