﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TechnicalInputChannel1Choice.  ISO2002 ID# _Rpr4odp-Ed-ak6NoX_4Aeg_-1373581543.
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
    /// Specifies the technical input channel.
    /// </summary>
    [KnownType(typeof(TechnicalInputChannel1Choice.Code))]
    [KnownType(typeof(TechnicalInputChannel1Choice.Proprietary))]
    [IsoId("_Rpr4odp-Ed-ak6NoX_4Aeg_-1373581543")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Technical Input Channel 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TechnicalInputChannel1Choice_
    #else
    public abstract partial class TechnicalInputChannel1Choice_
    #endif
    {
    }
}
