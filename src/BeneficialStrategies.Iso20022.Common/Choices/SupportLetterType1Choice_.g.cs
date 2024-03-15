﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SupportLetterType1Choice.  ISO2002 ID# _l_Ug0LbxEeu9Cp6InX88Vw.
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
    /// Choice of format for the type of supporting letter.
    /// </summary>
    [KnownType(typeof(SupportLetterType1Choice.Code))]
    [KnownType(typeof(SupportLetterType1Choice.Proprietary))]
    [IsoId("_l_Ug0LbxEeu9Cp6InX88Vw")]
    [DisplayName("Support Letter Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SupportLetterType1Choice_
    #else
    public abstract partial class SupportLetterType1Choice_
    #endif
    {
    }
}
