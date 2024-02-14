﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for UnableToApplyJustification3Choice.  ISO2002 ID# _SzxmAUgoEeaGKYpLDboHPQ.
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
    /// Specifies the details of missing or incorrect information or the complete set of available information.
    /// </summary>
    [KnownType(typeof(UnableToApplyJustification3Choice.AnyInformation))]
    [KnownType(typeof(UnableToApplyJustification3Choice.MissingOrIncorrectInformation))]
    [KnownType(typeof(UnableToApplyJustification3Choice.PossibleDuplicateInstruction))]
    [IsoId("_SzxmAUgoEeaGKYpLDboHPQ")]
    [DisplayName("Unable To Apply Justification 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnableToApplyJustification3Choice_
    #else
    public abstract partial class UnableToApplyJustification3Choice_
    #endif
    {
    }
}
