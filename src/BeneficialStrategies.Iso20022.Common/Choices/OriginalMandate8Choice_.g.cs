﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for OriginalMandate8Choice.  ISO2002 ID# _bPcdsdcZEeqRFcf2R4bPBw.
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
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate8Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate8Choice.OriginalMandate))]
    [IsoId("_bPcdsdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OriginalMandate8Choice_
    #else
    public abstract partial class OriginalMandate8Choice_
    #endif
    {
    }
}
