﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PurposeCode8Choice.  ISO2002 ID# _5Wx6YpNLEeWGlc8L7oPDIg.
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
    /// Choice between a code and or a data source scheme to determine the account type.
    /// </summary>
    [KnownType(typeof(PurposeCode8Choice.Code))]
    [KnownType(typeof(PurposeCode8Choice.Proprietary))]
    [IsoId("_5Wx6YpNLEeWGlc8L7oPDIg")]
    [DisplayName("Purpose Code 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PurposeCode8Choice_
    #else
    public abstract partial class PurposeCode8Choice_
    #endif
    {
    }
}
