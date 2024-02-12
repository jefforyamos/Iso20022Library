﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnitsOrAmountOrPercentage1Choice.  ISO2002 ID# _-TmAQQjcEeS5F6qHcKOrew.
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
    /// Choice between an amount or number of units or percentage.
    /// </summary>
    [KnownType(typeof(UnitsOrAmountOrPercentage1Choice.Amount))]
    [KnownType(typeof(UnitsOrAmountOrPercentage1Choice.Unit))]
    [KnownType(typeof(UnitsOrAmountOrPercentage1Choice.Percentage))]
    [IsoId("_-TmAQQjcEeS5F6qHcKOrew")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Units Or Amount Or Percentage 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitsOrAmountOrPercentage1Choice_
    #else
    public abstract partial class UnitsOrAmountOrPercentage1Choice_
    #endif
    {
    }
}
