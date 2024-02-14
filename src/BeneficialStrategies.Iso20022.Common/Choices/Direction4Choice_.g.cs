﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for Direction4Choice.  ISO2002 ID# _ZdjwgS0WEe2ZUuvBHegNNg.
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
    /// Choice between elements indicating the direction of the derivative transaction.
    /// </summary>
    [KnownType(typeof(Direction4Choice.Direction))]
    [KnownType(typeof(Direction4Choice.CounterpartySide))]
    [IsoId("_ZdjwgS0WEe2ZUuvBHegNNg")]
    [DisplayName("Direction 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Direction4Choice_
    #else
    public abstract partial class Direction4Choice_
    #endif
    {
    }
}
