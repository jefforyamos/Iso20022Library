﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IdentificationType2Choice.  ISO2002 ID# _Q-Undtp-Ed-ak6NoX_4Aeg_-1566348160.
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
    [KnownType(typeof(IdentificationType2Choice.Code))]
    [KnownType(typeof(IdentificationType2Choice.Proprietary))]
    [IsoId("_Q-Undtp-Ed-ak6NoX_4Aeg_-1566348160")]
    [DisplayName("Identification Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IdentificationType2Choice_
    #else
    public abstract partial class IdentificationType2Choice_
    #endif
    {
    }
}
