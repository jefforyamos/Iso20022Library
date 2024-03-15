﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CustomerConductClassification1Choice.  ISO2002 ID# _E0HGsxdwEeKYM7Bc71nDlA.
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
    /// Choice of formats for the specification of the customer conduct classification.
    /// </summary>
    [KnownType(typeof(CustomerConductClassification1Choice.Code))]
    [KnownType(typeof(CustomerConductClassification1Choice.Proprietary))]
    [IsoId("_E0HGsxdwEeKYM7Bc71nDlA")]
    [DisplayName("Customer Conduct Classification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CustomerConductClassification1Choice_
    #else
    public abstract partial class CustomerConductClassification1Choice_
    #endif
    {
    }
}
