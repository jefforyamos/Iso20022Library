﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AdditionalBusinessProcessFormat2Choice.  ISO2002 ID# _Q4XJZNp-Ed-ak6NoX_4Aeg_-329682049.
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
    [KnownType(typeof(AdditionalBusinessProcessFormat2Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat2Choice.Proprietary))]
    [IsoId("_Q4XJZNp-Ed-ak6NoX_4Aeg_-329682049")]
    [DisplayName("Additional Business Process Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdditionalBusinessProcessFormat2Choice_
    #else
    public abstract partial class AdditionalBusinessProcessFormat2Choice_
    #endif
    {
    }
}
