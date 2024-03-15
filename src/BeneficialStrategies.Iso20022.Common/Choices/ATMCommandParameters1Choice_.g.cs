﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ATMCommandParameters1Choice.  ISO2002 ID# _JTG3oIqLEeSRT5rEzcAHEw.
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
    /// Specific parameters attached to an ATM command.
    /// </summary>
    [KnownType(typeof(ATMCommandParameters1Choice.ATMRequiredGlobalStatus))]
    [KnownType(typeof(ATMCommandParameters1Choice.ExpectedMessageFunction))]
    [KnownType(typeof(ATMCommandParameters1Choice.RequiredConfigurationParameter))]
    [IsoId("_JTG3oIqLEeSRT5rEzcAHEw")]
    [DisplayName("ATM Command Parameters 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ATMCommandParameters1Choice_
    #else
    public abstract partial class ATMCommandParameters1Choice_
    #endif
    {
    }
}
