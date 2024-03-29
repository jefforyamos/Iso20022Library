﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Reversible2Choice.  ISO2002 ID# _PFD-kZEkEeakHoV5BVecAQ.
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
    /// Choice between a code or a data source scheme to determine the closing of the securities lending contract.
    /// </summary>
    [KnownType(typeof(Reversible2Choice.Code))]
    [KnownType(typeof(Reversible2Choice.Proprietary))]
    [IsoId("_PFD-kZEkEeakHoV5BVecAQ")]
    [DisplayName("Reversible 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reversible2Choice_
    #else
    public abstract partial class Reversible2Choice_
    #endif
    {
    }
}
