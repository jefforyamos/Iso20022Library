﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AffirmationReason1Choice.  ISO2002 ID# _Azo44NokEeC60axPepSq7g_-579916981.
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
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationReason1Choice.Reason))]
    [KnownType(typeof(AffirmationReason1Choice.NoSpecifiedReason))]
    [IsoId("_Azo44NokEeC60axPepSq7g_-579916981")]
    [DisplayName("Affirmation Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AffirmationReason1Choice_
    #else
    public abstract partial class AffirmationReason1Choice_
    #endif
    {
    }
}
