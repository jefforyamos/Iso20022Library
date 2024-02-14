﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for AutomaticBorrowing5Choice.  ISO2002 ID# _AY9vFNokEeC60axPepSq7g_1505904556.
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
    /// Choice of format for the automatic borrowing information.
    /// </summary>
    [KnownType(typeof(AutomaticBorrowing5Choice.Code))]
    [KnownType(typeof(AutomaticBorrowing5Choice.Proprietary))]
    [IsoId("_AY9vFNokEeC60axPepSq7g_1505904556")]
    [DisplayName("Automatic Borrowing 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AutomaticBorrowing5Choice_
    #else
    public abstract partial class AutomaticBorrowing5Choice_
    #endif
    {
    }
}
