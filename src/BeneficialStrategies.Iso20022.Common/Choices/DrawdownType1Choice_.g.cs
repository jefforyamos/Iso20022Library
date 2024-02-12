﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for DrawdownType1Choice.  ISO2002 ID# _NHMP4FNdEeijdq8ilaxyOA.
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
    /// Choice of formats for a type of drawdown.
    /// </summary>
    [KnownType(typeof(DrawdownType1Choice.Code))]
    [KnownType(typeof(DrawdownType1Choice.Proprietary))]
    [IsoId("_NHMP4FNdEeijdq8ilaxyOA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Drawdown Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DrawdownType1Choice_
    #else
    public abstract partial class DrawdownType1Choice_
    #endif
    {
    }
}
