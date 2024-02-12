﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SystemPartyType1Choice.  ISO2002 ID# _DZrOc1hPEeih3fUfzR38Ig.
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
    /// Specifies the system party type.
    /// </summary>
    [KnownType(typeof(SystemPartyType1Choice.Code))]
    [KnownType(typeof(SystemPartyType1Choice.Proprietary))]
    [IsoId("_DZrOc1hPEeih3fUfzR38Ig")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("System Party Type 1 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemPartyType1Choice_
    #else
    public abstract partial class SystemPartyType1Choice_
    #endif
    {
    }
}
