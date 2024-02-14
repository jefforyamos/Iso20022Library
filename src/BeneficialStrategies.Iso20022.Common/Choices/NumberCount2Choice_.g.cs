﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NumberCount2Choice.  ISO2002 ID# _JBmOYSgdEey2k_sfZmJz4g.
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
    /// Choice of number count type.
    /// </summary>
    [KnownType(typeof(NumberCount2Choice.CurrentInstructionNumber))]
    [KnownType(typeof(NumberCount2Choice.TotalNumber))]
    [IsoId("_JBmOYSgdEey2k_sfZmJz4g")]
    [DisplayName("Number Count 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NumberCount2Choice_
    #else
    public abstract partial class NumberCount2Choice_
    #endif
    {
    }
}
