﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IdentificationFormat4Choice.  ISO2002 ID# _c5VTNZKQEeWHWpTQn1FFVg.
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
    /// Choice between either a short, long or a proprietary identification format.
    /// </summary>
    [KnownType(typeof(IdentificationFormat4Choice.ShortIdentification))]
    [KnownType(typeof(IdentificationFormat4Choice.LongIdentification))]
    [KnownType(typeof(IdentificationFormat4Choice.ProprietaryIdentification))]
    [IsoId("_c5VTNZKQEeWHWpTQn1FFVg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification Format 4 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationFormat4Choice_
    #else
    public abstract partial class IdentificationFormat4Choice_
    #endif
    {
    }
}
