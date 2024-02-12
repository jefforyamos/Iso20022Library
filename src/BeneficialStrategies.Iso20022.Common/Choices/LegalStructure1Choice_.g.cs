﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LegalStructure1Choice.  ISO2002 ID# _kfzX0DQeEeifw8iDiyZLmQ.
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
    /// Choice of formats for the legal structure of a financial instrument.
    /// </summary>
    [KnownType(typeof(LegalStructure1Choice.Code))]
    [KnownType(typeof(LegalStructure1Choice.Proprietary))]
    [IsoId("_kfzX0DQeEeifw8iDiyZLmQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Legal Structure 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LegalStructure1Choice_
    #else
    public abstract partial class LegalStructure1Choice_
    #endif
    {
    }
}
