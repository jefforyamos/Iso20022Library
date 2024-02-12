﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InvestigationStatus4Choice.  ISO2002 ID# _nTQy8YmxEeeKR__nUfxjwA.
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
    /// Specifies the status of an investigation case.
    /// </summary>
    [KnownType(typeof(InvestigationStatus4Choice.Confirmation))]
    [KnownType(typeof(InvestigationStatus4Choice.RejectedModification))]
    [KnownType(typeof(InvestigationStatus4Choice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatus4Choice.AssignmentCancellationConfirmation))]
    [IsoId("_nTQy8YmxEeeKR__nUfxjwA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investigation Status 4 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestigationStatus4Choice_
    #else
    public abstract partial class InvestigationStatus4Choice_
    #endif
    {
    }
}
