﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InitialPhysicalForm4Choice.  ISO2002 ID# _UjitceLxEeWOD7aAy2fAcA.
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
    /// Choice of format for initial physical form.
    /// </summary>
    [KnownType(typeof(InitialPhysicalForm4Choice.Code))]
    [KnownType(typeof(InitialPhysicalForm4Choice.Proprietary))]
    [IsoId("_UjitceLxEeWOD7aAy2fAcA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Initial Physical Form 4 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InitialPhysicalForm4Choice_
    #else
    public abstract partial class InitialPhysicalForm4Choice_
    #endif
    {
    }
}
