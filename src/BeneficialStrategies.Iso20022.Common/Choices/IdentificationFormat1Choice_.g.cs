﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IdentificationFormat1Choice.  ISO2002 ID# _Q4EOcNp-Ed-ak6NoX_4Aeg_-298747388.
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
    /// Choice between either a short, long or a proprietary identification format.
    /// </summary>
    [KnownType(typeof(IdentificationFormat1Choice.ShortIdentification))]
    [KnownType(typeof(IdentificationFormat1Choice.LongIdentification))]
    [KnownType(typeof(IdentificationFormat1Choice.ProprietaryIdentification))]
    [IsoId("_Q4EOcNp-Ed-ak6NoX_4Aeg_-298747388")]
    [DisplayName("Identification Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationFormat1Choice_
    #else
    public abstract partial class IdentificationFormat1Choice_
    #endif
    {
    }
}
