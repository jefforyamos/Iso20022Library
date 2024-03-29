﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxableIncomePerShareCalculatedType1Choice.  ISO2002 ID# _RfQKQtp-Ed-ak6NoX_4Aeg_1317820500.
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
    /// Choice of a taxable income per share calcualted type.
    /// </summary>
    [KnownType(typeof(TaxableIncomePerShareCalculatedType1Choice.TaxableIncomePerShareCalculated))]
    [KnownType(typeof(TaxableIncomePerShareCalculatedType1Choice.Proprietary))]
    [IsoId("_RfQKQtp-Ed-ak6NoX_4Aeg_1317820500")]
    [DisplayName("Taxable Income Per Share Calculated Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxableIncomePerShareCalculatedType1Choice_
    #else
    public abstract partial class TaxableIncomePerShareCalculatedType1Choice_
    #endif
    {
    }
}
