﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxBasis1Choice.  ISO2002 ID# _S9_-wRuIEeOqSdXzJ0oydA.
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
    /// Choice of formats for the tax basis.
    /// </summary>
    [KnownType(typeof(TaxBasis1Choice.Code))]
    [KnownType(typeof(TaxBasis1Choice.Proprietary))]
    [IsoId("_S9_-wRuIEeOqSdXzJ0oydA")]
    [DisplayName("Tax Basis 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxBasis1Choice_
    #else
    public abstract partial class TaxBasis1Choice_
    #endif
    {
    }
}
