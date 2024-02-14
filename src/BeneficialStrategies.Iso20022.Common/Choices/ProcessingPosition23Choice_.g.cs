﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingPosition23Choice.  ISO2002 ID# _BQvScb-DEeW_u_CSZtGM1g.
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
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition23Choice.Code))]
    [KnownType(typeof(ProcessingPosition23Choice.Proprietary))]
    [IsoId("_BQvScb-DEeW_u_CSZtGM1g")]
    [DisplayName("Processing Position 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingPosition23Choice_
    #else
    public abstract partial class ProcessingPosition23Choice_
    #endif
    {
    }
}
