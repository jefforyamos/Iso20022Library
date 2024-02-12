﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LocalInstrument1Choice.  ISO2002 ID# _TGhDB9p-Ed-ak6NoX_4Aeg_-2017969290.
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
    [KnownType(typeof(LocalInstrument1Choice.Code))]
    [KnownType(typeof(LocalInstrument1Choice.Proprietary))]
    [IsoId("_TGhDB9p-Ed-ak6NoX_4Aeg_-2017969290")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Local Instrument 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LocalInstrument1Choice_
    #else
    public abstract partial class LocalInstrument1Choice_
    #endif
    {
    }
}
