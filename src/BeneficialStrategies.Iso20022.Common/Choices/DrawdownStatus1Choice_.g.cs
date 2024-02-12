﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DrawdownStatus1Choice.  ISO2002 ID# _bM0XwFKiEeiSDqv62fL07g.
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
    /// Choice of formats for a drawdown status.
    /// </summary>
    [KnownType(typeof(DrawdownStatus1Choice.Code))]
    [KnownType(typeof(DrawdownStatus1Choice.Proprietary))]
    [IsoId("_bM0XwFKiEeiSDqv62fL07g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Drawdown Status 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DrawdownStatus1Choice_
    #else
    public abstract partial class DrawdownStatus1Choice_
    #endif
    {
    }
}
