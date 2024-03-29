﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ValidationRuleSchemeName1Choice.  ISO2002 ID# _kAjWY9jGEeSD0e0ybx5L5Q.
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
    /// Identifies a name of the identification scheme.
    /// </summary>
    [KnownType(typeof(ValidationRuleSchemeName1Choice.Code))]
    [KnownType(typeof(ValidationRuleSchemeName1Choice.Proprietary))]
    [IsoId("_kAjWY9jGEeSD0e0ybx5L5Q")]
    [DisplayName("Validation Rule Scheme Name 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ValidationRuleSchemeName1Choice_
    #else
    public abstract partial class ValidationRuleSchemeName1Choice_
    #endif
    {
    }
}
