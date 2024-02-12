﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepairStatus8Choice.  ISO2002 ID# _0ka00AlIEeGATtfOBToyew_412690380.
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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus8Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus8Choice.Reason))]
    [IsoId("_0ka00AlIEeGATtfOBToyew_412690380")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Repair Status 8 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepairStatus8Choice_
    #else
    public abstract partial class RepairStatus8Choice_
    #endif
    {
    }
}
