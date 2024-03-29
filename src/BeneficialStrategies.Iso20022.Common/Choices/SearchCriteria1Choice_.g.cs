﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SearchCriteria1Choice.  ISO2002 ID# _sxyTUDv7EeGKuZXNQxGH3g.
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
    /// Choice of search criteria for the financial investigation.
    /// </summary>
    [KnownType(typeof(SearchCriteria1Choice.Account))]
    [KnownType(typeof(SearchCriteria1Choice.CustomerIdentification))]
    [KnownType(typeof(SearchCriteria1Choice.PaymentInstrument))]
    [KnownType(typeof(SearchCriteria1Choice.OriginalTransactionNumber))]
    [IsoId("_sxyTUDv7EeGKuZXNQxGH3g")]
    [DisplayName("Search Criteria 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SearchCriteria1Choice_
    #else
    public abstract partial class SearchCriteria1Choice_
    #endif
    {
    }
}
