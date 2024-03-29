﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LocalInstrument2Choice.  ISO2002 ID# _TF7NItp-Ed-ak6NoX_4Aeg_365018897.
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
    /// Set of elements that further identifies the type of local instruments being requested by the initiating party.
    /// </summary>
    [KnownType(typeof(LocalInstrument2Choice.Code))]
    [KnownType(typeof(LocalInstrument2Choice.Proprietary))]
    [IsoId("_TF7NItp-Ed-ak6NoX_4Aeg_365018897")]
    [DisplayName("Local Instrument 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LocalInstrument2Choice_
    #else
    public abstract partial class LocalInstrument2Choice_
    #endif
    {
    }
}
