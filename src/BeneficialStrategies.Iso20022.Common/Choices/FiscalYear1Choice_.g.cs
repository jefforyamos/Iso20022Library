﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FiscalYear1Choice.  ISO2002 ID# _534EEFxREeW8MLuBzR10cg.
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
    /// Choice of start date and end date for the fiscal year.
    /// </summary>
    [KnownType(typeof(FiscalYear1Choice.StartDate))]
    [KnownType(typeof(FiscalYear1Choice.EndDate))]
    [IsoId("_534EEFxREeW8MLuBzR10cg")]
    [DisplayName("Fiscal Year 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FiscalYear1Choice_
    #else
    public abstract partial class FiscalYear1Choice_
    #endif
    {
    }
}
