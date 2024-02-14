﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AdditionalBusinessProcessFormat14Choice.  ISO2002 ID# _979uqZqZEeWNO_b7eN4F_w.
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
    [KnownType(typeof(AdditionalBusinessProcessFormat14Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat14Choice.Proprietary))]
    [IsoId("_979uqZqZEeWNO_b7eN4F_w")]
    [DisplayName("Additional Business Process Format 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdditionalBusinessProcessFormat14Choice_
    #else
    public abstract partial class AdditionalBusinessProcessFormat14Choice_
    #endif
    {
    }
}
