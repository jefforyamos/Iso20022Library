﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FXCancellation4Choice.  ISO2002 ID# _8T_SwZNLEeWGlc8L7oPDIg.
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
    /// Choice of format for the forex cancellation information.
    /// </summary>
    [KnownType(typeof(FXCancellation4Choice.Indicator))]
    [KnownType(typeof(FXCancellation4Choice.Proprietary))]
    [IsoId("_8T_SwZNLEeWGlc8L7oPDIg")]
    [DisplayName("FX Cancellation 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FXCancellation4Choice_
    #else
    public abstract partial class FXCancellation4Choice_
    #endif
    {
    }
}
