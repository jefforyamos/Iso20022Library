﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LimitStructure1Choice.  ISO2002 ID# _72iECKMgEeCJ6YNENx4h-w_-879339844.
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
    /// Limit details of one or more limits set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(LimitStructure1Choice.CurrentLimitIdentification))]
    [KnownType(typeof(LimitStructure1Choice.AllCurrentLimits))]
    [IsoId("_72iECKMgEeCJ6YNENx4h-w_-879339844")]
    [DisplayName("Limit Structure 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LimitStructure1Choice_
    #else
    public abstract partial class LimitStructure1Choice_
    #endif
    {
    }
}
