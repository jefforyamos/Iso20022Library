﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for LetterOfGuarantee3Choice.  ISO2002 ID# _AY9vEdokEeC60axPepSq7g_-1666647769.
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
    /// Choice of format for the letter of guarantee information.
    /// </summary>
    [KnownType(typeof(LetterOfGuarantee3Choice.Indicator))]
    [KnownType(typeof(LetterOfGuarantee3Choice.Proprietary))]
    [IsoId("_AY9vEdokEeC60axPepSq7g_-1666647769")]
    [DisplayName("Letter Of Guarantee 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LetterOfGuarantee3Choice_
    #else
    public abstract partial class LetterOfGuarantee3Choice_
    #endif
    {
    }
}
