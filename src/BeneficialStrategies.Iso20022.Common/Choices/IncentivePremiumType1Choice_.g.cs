﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IncentivePremiumType1Choice.  ISO2002 ID# _RDieodp-Ed-ak6NoX_4Aeg_1038160776.
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
    /// Choice of cash premium paid to the security holder when voting.
    /// </summary>
    [KnownType(typeof(IncentivePremiumType1Choice.PerSecurity))]
    [KnownType(typeof(IncentivePremiumType1Choice.PerVote))]
    [KnownType(typeof(IncentivePremiumType1Choice.PerAttendee))]
    [IsoId("_RDieodp-Ed-ak6NoX_4Aeg_1038160776")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Incentive Premium Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IncentivePremiumType1Choice_
    #else
    public abstract partial class IncentivePremiumType1Choice_
    #endif
    {
    }
}
