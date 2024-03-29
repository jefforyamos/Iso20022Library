﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Restriction3Choice.  ISO2002 ID# _AZabBNokEeC60axPepSq7g_692067563.
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
    /// Choice of format for the securities restriction information.
    /// </summary>
    [KnownType(typeof(Restriction3Choice.Code))]
    [KnownType(typeof(Restriction3Choice.Proprietary))]
    [IsoId("_AZabBNokEeC60axPepSq7g_692067563")]
    [DisplayName("Restriction 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Restriction3Choice_
    #else
    public abstract partial class Restriction3Choice_
    #endif
    {
    }
}
