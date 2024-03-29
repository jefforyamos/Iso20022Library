﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InformationTypeFormat1Choice.  ISO2002 ID# __SFAwCXaEeOFIcNWlDEvdQ.
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
    /// Choice between a standard code or proprietary code to specify the information type format required.
    /// </summary>
    [KnownType(typeof(InformationTypeFormat1Choice.Code))]
    [KnownType(typeof(InformationTypeFormat1Choice.Proprietary))]
    [IsoId("__SFAwCXaEeOFIcNWlDEvdQ")]
    [DisplayName("Information Type Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InformationTypeFormat1Choice_
    #else
    public abstract partial class InformationTypeFormat1Choice_
    #endif
    {
    }
}
