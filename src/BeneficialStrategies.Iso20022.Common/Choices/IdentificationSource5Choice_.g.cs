﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IdentificationSource5Choice.  ISO2002 ID# _nfUx0V9NEeS7xuKaq75oiQ.
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
    /// Choice between source of identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(IdentificationSource5Choice.DomesticIdentificationSource))]
    [KnownType(typeof(IdentificationSource5Choice.ProprietaryIdentificationSource))]
    [IsoId("_nfUx0V9NEeS7xuKaq75oiQ")]
    [DisplayName("Identification Source 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationSource5Choice_
    #else
    public abstract partial class IdentificationSource5Choice_
    #endif
    {
    }
}
