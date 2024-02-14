﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RejectionReason21FormatChoice.  ISO2002 ID# _Qki1gdp-Ed-ak6NoX_4Aeg_172364056.
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
    /// Choice of formats to express the reason of a rejection of the interest request.
    /// </summary>
    [KnownType(typeof(RejectionReason21FormatChoice.Code))]
    [KnownType(typeof(RejectionReason21FormatChoice.Proprietary))]
    [IsoId("_Qki1gdp-Ed-ak6NoX_4Aeg_172364056")]
    [DisplayName("Rejection Reason 21 Format Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RejectionReason21FormatChoice_
    #else
    public abstract partial class RejectionReason21FormatChoice_
    #endif
    {
    }
}
