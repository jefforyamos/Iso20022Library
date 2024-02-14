﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Registration10Choice.  ISO2002 ID# _zWwOFTqfEeWyoP0PbocV1Q.
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
    /// Choice of format for the registration information.
    /// </summary>
    [KnownType(typeof(Registration10Choice.Code))]
    [KnownType(typeof(Registration10Choice.Proprietary))]
    [IsoId("_zWwOFTqfEeWyoP0PbocV1Q")]
    [DisplayName("Registration 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Registration10Choice_
    #else
    public abstract partial class Registration10Choice_
    #endif
    {
    }
}
