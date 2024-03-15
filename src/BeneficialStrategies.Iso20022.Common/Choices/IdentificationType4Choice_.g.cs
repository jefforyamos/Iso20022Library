﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IdentificationType4Choice.  ISO2002 ID# _Q4qEW9p-Ed-ak6NoX_4Aeg_436704411.
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
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType4Choice.Code))]
    [KnownType(typeof(IdentificationType4Choice.Proprietary))]
    [IsoId("_Q4qEW9p-Ed-ak6NoX_4Aeg_436704411")]
    [DisplayName("Identification Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationType4Choice_
    #else
    public abstract partial class IdentificationType4Choice_
    #endif
    {
    }
}
