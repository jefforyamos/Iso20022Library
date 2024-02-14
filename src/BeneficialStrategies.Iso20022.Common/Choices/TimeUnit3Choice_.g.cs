﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TimeUnit3Choice.  ISO2002 ID# _oIB4MeLaEeWFtOV72FbX9w.
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
    /// Choice of format for time unit.
    /// </summary>
    [KnownType(typeof(TimeUnit3Choice.Code))]
    [KnownType(typeof(TimeUnit3Choice.Proprietary))]
    [IsoId("_oIB4MeLaEeWFtOV72FbX9w")]
    [DisplayName("Time Unit 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TimeUnit3Choice_
    #else
    public abstract partial class TimeUnit3Choice_
    #endif
    {
    }
}
