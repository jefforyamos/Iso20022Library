﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InterestRate1Choice.  ISO2002 ID# _Qk1wctp-Ed-ak6NoX_4Aeg_-868217621.
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
    /// Choice between a fixed rate and a variable rate.
    /// </summary>
    [KnownType(typeof(InterestRate1Choice.FixedInterestRate))]
    [KnownType(typeof(InterestRate1Choice.VariableInterestRate))]
    [IsoId("_Qk1wctp-Ed-ak6NoX_4Aeg_-868217621")]
    [DisplayName("Interest Rate 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRate1Choice_
    #else
    public abstract partial class InterestRate1Choice_
    #endif
    {
    }
}
