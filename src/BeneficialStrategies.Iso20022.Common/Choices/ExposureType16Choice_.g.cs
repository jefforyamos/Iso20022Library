﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ExposureType16Choice.  ISO2002 ID# _UCM-ETtEEeWRTLSN0i0tng.
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
    /// Choice of format for the exposure information.
    /// </summary>
    [KnownType(typeof(ExposureType16Choice.Code))]
    [KnownType(typeof(ExposureType16Choice.Proprietary))]
    [IsoId("_UCM-ETtEEeWRTLSN0i0tng")]
    [DisplayName("Exposure Type 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExposureType16Choice_
    #else
    public abstract partial class ExposureType16Choice_
    #endif
    {
    }
}
