﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InvestmentAccountType1Choice.  ISO2002 ID# _C6GQ4xdLEeK5g-3oYI0_9Q.
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
    /// Choice of formats for the specification of the investment account type.
    /// </summary>
    [KnownType(typeof(InvestmentAccountType1Choice.Code))]
    [KnownType(typeof(InvestmentAccountType1Choice.Proprietary))]
    [IsoId("_C6GQ4xdLEeK5g-3oYI0_9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investment Account Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestmentAccountType1Choice_
    #else
    public abstract partial class InvestmentAccountType1Choice_
    #endif
    {
    }
}
