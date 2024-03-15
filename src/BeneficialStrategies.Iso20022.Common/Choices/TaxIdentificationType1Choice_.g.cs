﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxIdentificationType1Choice.  ISO2002 ID# _yWmpEAhIEeSUPbC7DbLJpQ.
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
    /// Choice of formats for the type of tax identification.
    /// </summary>
    [KnownType(typeof(TaxIdentificationType1Choice.Code))]
    [KnownType(typeof(TaxIdentificationType1Choice.Proprietary))]
    [IsoId("_yWmpEAhIEeSUPbC7DbLJpQ")]
    [DisplayName("Tax Identification Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxIdentificationType1Choice_
    #else
    public abstract partial class TaxIdentificationType1Choice_
    #endif
    {
    }
}
