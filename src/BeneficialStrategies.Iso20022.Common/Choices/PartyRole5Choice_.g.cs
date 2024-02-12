﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PartyRole5Choice.  ISO2002 ID# _pSfUISDSEeWCLu74WLgP4w.
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
    [KnownType(typeof(PartyRole5Choice.Code))]
    [KnownType(typeof(PartyRole5Choice.Proprietary))]
    [IsoId("_pSfUISDSEeWCLu74WLgP4w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Party Role 5 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyRole5Choice_
    #else
    public abstract partial class PartyRole5Choice_
    #endif
    {
    }
}
