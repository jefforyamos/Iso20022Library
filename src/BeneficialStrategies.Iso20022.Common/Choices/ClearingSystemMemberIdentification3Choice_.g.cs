﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ClearingSystemMemberIdentification3Choice.  ISO2002 ID# _TMehGdp-Ed-ak6NoX_4Aeg_-1564562098.
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
    /// Choice of identifiers for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
    /// </summary>
    [KnownType(typeof(ClearingSystemMemberIdentification3Choice.Identification))]
    [KnownType(typeof(ClearingSystemMemberIdentification3Choice.Proprietary))]
    [IsoId("_TMehGdp-Ed-ak6NoX_4Aeg_-1564562098")]
    [DisplayName("Clearing System Member Identification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ClearingSystemMemberIdentification3Choice_
    #else
    public abstract partial class ClearingSystemMemberIdentification3Choice_
    #endif
    {
    }
}
