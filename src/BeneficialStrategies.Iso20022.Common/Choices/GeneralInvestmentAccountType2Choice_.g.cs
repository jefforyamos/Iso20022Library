﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GeneralInvestmentAccountType2Choice.  ISO2002 ID# _4CGG0ZNuEembCsVG-3f_AA.
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
    /// Choice of formats for a type of investment account.
    /// </summary>
    [KnownType(typeof(GeneralInvestmentAccountType2Choice.Code))]
    [KnownType(typeof(GeneralInvestmentAccountType2Choice.Proprietary))]
    [IsoId("_4CGG0ZNuEembCsVG-3f_AA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("General Investment Account Type 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GeneralInvestmentAccountType2Choice_
    #else
    public abstract partial class GeneralInvestmentAccountType2Choice_
    #endif
    {
    }
}
