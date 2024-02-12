﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RepairStatus6Choice.  ISO2002 ID# _Vn3Okf7rEeCvPoRGOxRobQ.
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
    [KnownType(typeof(RepairStatus6Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus6Choice.Reason))]
    [IsoId("_Vn3Okf7rEeCvPoRGOxRobQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Repair Status 6 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RepairStatus6Choice_
    #else
    public abstract partial class RepairStatus6Choice_
    #endif
    {
    }
}
