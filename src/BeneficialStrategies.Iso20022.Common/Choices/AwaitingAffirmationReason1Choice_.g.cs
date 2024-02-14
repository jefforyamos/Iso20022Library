﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AwaitingAffirmationReason1Choice.  ISO2002 ID# _A6MM0NokEeC60axPepSq7g_-1469713993.
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
    /// Choice of format for the Awaiting Affirmation reason.
    /// </summary>
    [KnownType(typeof(AwaitingAffirmationReason1Choice.Code))]
    [KnownType(typeof(AwaitingAffirmationReason1Choice.Proprietary))]
    [IsoId("_A6MM0NokEeC60axPepSq7g_-1469713993")]
    [DisplayName("Awaiting Affirmation Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AwaitingAffirmationReason1Choice_
    #else
    public abstract partial class AwaitingAffirmationReason1Choice_
    #endif
    {
    }
}
