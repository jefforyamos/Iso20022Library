﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SystemMemberStatus1Choice.  ISO2002 ID# _V4OMw3hhEeidzqjNEfehPg.
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
    /// Specifies the status of a member within a system.
    /// </summary>
    [KnownType(typeof(SystemMemberStatus1Choice.Code))]
    [KnownType(typeof(SystemMemberStatus1Choice.Proprietary))]
    [IsoId("_V4OMw3hhEeidzqjNEfehPg")]
    [DisplayName("System Member Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SystemMemberStatus1Choice_
    #else
    public abstract partial class SystemMemberStatus1Choice_
    #endif
    {
    }
}
