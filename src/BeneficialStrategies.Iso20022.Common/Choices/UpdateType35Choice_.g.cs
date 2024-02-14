﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UpdateType35Choice.  ISO2002 ID# _QMJpmZJKEeuAlLVx8pyt3w.
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
    /// Choice between action to request on a security.
    /// </summary>
    [KnownType(typeof(UpdateType35Choice.Add))]
    [KnownType(typeof(UpdateType35Choice.Delete))]
    [KnownType(typeof(UpdateType35Choice.Modify))]
    [IsoId("_QMJpmZJKEeuAlLVx8pyt3w")]
    [DisplayName("Update Type 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType35Choice_
    #else
    public abstract partial class UpdateType35Choice_
    #endif
    {
    }
}
