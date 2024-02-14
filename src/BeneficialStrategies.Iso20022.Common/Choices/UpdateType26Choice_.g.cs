﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UpdateType26Choice.  ISO2002 ID# _JfG62Zw3EeazcsnODTksnQ.
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
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType26Choice.Addition))]
    [KnownType(typeof(UpdateType26Choice.Deletion))]
    [KnownType(typeof(UpdateType26Choice.Modification))]
    [IsoId("_JfG62Zw3EeazcsnODTksnQ")]
    [DisplayName("Update Type 26 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UpdateType26Choice_
    #else
    public abstract partial class UpdateType26Choice_
    #endif
    {
    }
}
