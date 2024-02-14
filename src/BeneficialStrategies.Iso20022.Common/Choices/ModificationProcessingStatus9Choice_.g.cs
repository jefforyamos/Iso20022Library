﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ModificationProcessingStatus9Choice.  ISO2002 ID# _w6pyceF8EeWCAvUNsZ5u6g.
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
    /// Choice of modification processing status.
    /// </summary>
    [KnownType(typeof(ModificationProcessingStatus9Choice.Code))]
    [KnownType(typeof(ModificationProcessingStatus9Choice.Proprietary))]
    [IsoId("_w6pyceF8EeWCAvUNsZ5u6g")]
    [DisplayName("Modification Processing Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModificationProcessingStatus9Choice_
    #else
    public abstract partial class ModificationProcessingStatus9Choice_
    #endif
    {
    }
}
