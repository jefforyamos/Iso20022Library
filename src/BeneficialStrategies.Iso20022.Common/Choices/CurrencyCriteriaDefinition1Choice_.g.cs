﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CurrencyCriteriaDefinition1Choice.  ISO2002 ID# _HxiIV5lZEeeE1Ya-LgRsuQ.
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
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(CurrencyCriteriaDefinition1Choice.QueryName))]
    [KnownType(typeof(CurrencyCriteriaDefinition1Choice.NewCriteria))]
    [IsoId("_HxiIV5lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Currency Criteria Definition 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CurrencyCriteriaDefinition1Choice_
    #else
    public abstract partial class CurrencyCriteriaDefinition1Choice_
    #endif
    {
    }
}
