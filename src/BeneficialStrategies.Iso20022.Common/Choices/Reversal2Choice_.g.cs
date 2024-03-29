﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Reversal2Choice.  ISO2002 ID# _PsjTARg4EeK-_89we2b-bA.
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
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [KnownType(typeof(Reversal2Choice.Reference))]
    [KnownType(typeof(Reversal2Choice.TransferInConfirmationDetails))]
    [IsoId("_PsjTARg4EeK-_89we2b-bA")]
    [DisplayName("Reversal 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Reversal2Choice_
    #else
    public abstract partial class Reversal2Choice_
    #endif
    {
    }
}
