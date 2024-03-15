﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InstrumentSubStructureType2Choice.  ISO2002 ID# _QYb2YeLaEeWFtOV72FbX9w.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Choice of format for a instrument sub-structure type.
    /// </summary>
    [KnownType(typeof(InstrumentSubStructureType2Choice.Code))]
    [KnownType(typeof(InstrumentSubStructureType2Choice.Proprietary))]
    [IsoId("_QYb2YeLaEeWFtOV72FbX9w")]
    [DisplayName("Instrument Sub Structure Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstrumentSubStructureType2Choice_
    #else
    public abstract partial class InstrumentSubStructureType2Choice_
    #endif
    {
    }
}
