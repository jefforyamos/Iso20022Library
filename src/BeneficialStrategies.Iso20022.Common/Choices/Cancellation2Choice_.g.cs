﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Cancellation2Choice.  ISO2002 ID# _Nv8HQRg2EeK-_89we2b-bA.
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
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [KnownType(typeof(Cancellation2Choice.Reference))]
    [KnownType(typeof(Cancellation2Choice.TransferInDetails))]
    [IsoId("_Nv8HQRg2EeK-_89we2b-bA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cancellation 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cancellation2Choice_
    #else
    public abstract partial class Cancellation2Choice_
    #endif
    {
    }
}
