﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CharacterSearch1Choice.  ISO2002 ID# _F7k20ZlaEeeE1Ya-LgRsuQ.
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
    /// Set of characters to be matched to be considered as valid.
    /// </summary>
    [KnownType(typeof(CharacterSearch1Choice.Equal))]
    [KnownType(typeof(CharacterSearch1Choice.NotEqual))]
    [KnownType(typeof(CharacterSearch1Choice.Contain))]
    [KnownType(typeof(CharacterSearch1Choice.NotContain))]
    [IsoId("_F7k20ZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Character Search 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CharacterSearch1Choice_
    #else
    public abstract partial class CharacterSearch1Choice_
    #endif
    {
    }
}
