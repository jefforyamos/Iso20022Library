﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxAmountType1Choice.  ISO2002 ID# _tsra0lkyEeGeoaLUQk__nA_-1905418813.
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
    /// Specifies the amount type.
    /// </summary>
    [KnownType(typeof(TaxAmountType1Choice.Code))]
    [KnownType(typeof(TaxAmountType1Choice.Proprietary))]
    [IsoId("_tsra0lkyEeGeoaLUQk__nA_-1905418813")]
    [DisplayName("Tax Amount Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxAmountType1Choice_
    #else
    public abstract partial class TaxAmountType1Choice_
    #endif
    {
    }
}
