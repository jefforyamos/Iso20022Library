﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for FundPortfolio7Choice.  ISO2002 ID# _Xn1_oelfEeu9cf4XM82AQQ.
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
    /// Choice of different types of portfolio.
    /// </summary>
    [KnownType(typeof(FundPortfolio7Choice.TaxEfficientProduct))]
    [KnownType(typeof(FundPortfolio7Choice.GeneralInvestment))]
    [KnownType(typeof(FundPortfolio7Choice.Pension))]
    [IsoId("_Xn1_oelfEeu9cf4XM82AQQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Fund Portfolio 7 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FundPortfolio7Choice_
    #else
    public abstract partial class FundPortfolio7Choice_
    #endif
    {
    }
}
