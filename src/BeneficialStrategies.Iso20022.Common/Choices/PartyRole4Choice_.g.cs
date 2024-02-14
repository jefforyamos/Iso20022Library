﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyRole4Choice.  ISO2002 ID# _XXtRYV92EeS7xuKaq75oiQ.
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
    /// Choice of formats for the specification of the role.
    /// </summary>
    [KnownType(typeof(PartyRole4Choice.Code))]
    [KnownType(typeof(PartyRole4Choice.Proprietary))]
    [IsoId("_XXtRYV92EeS7xuKaq75oiQ")]
    [DisplayName("Party Role 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyRole4Choice_
    #else
    public abstract partial class PartyRole4Choice_
    #endif
    {
    }
}
