﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Reversible1Choice.  ISO2002 ID# _AYOIONokEeC60axPepSq7g_-1179089003.
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
    [KnownType(typeof(Reversible1Choice.Code))]
    [KnownType(typeof(Reversible1Choice.Proprietary))]
    [IsoId("_AYOIONokEeC60axPepSq7g_-1179089003")]
    [DisplayName("Reversible 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reversible1Choice_
    #else
    public abstract partial class Reversible1Choice_
    #endif
    {
    }
}
