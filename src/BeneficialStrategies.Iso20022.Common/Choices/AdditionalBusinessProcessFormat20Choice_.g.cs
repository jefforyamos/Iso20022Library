﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AdditionalBusinessProcessFormat20Choice.  ISO2002 ID# _plRhEzi7Eeydid5dcNPKvg.
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
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat20Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat20Choice.Proprietary))]
    [IsoId("_plRhEzi7Eeydid5dcNPKvg")]
    [DisplayName("Additional Business Process Format 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdditionalBusinessProcessFormat20Choice_
    #else
    public abstract partial class AdditionalBusinessProcessFormat20Choice_
    #endif
    {
    }
}
