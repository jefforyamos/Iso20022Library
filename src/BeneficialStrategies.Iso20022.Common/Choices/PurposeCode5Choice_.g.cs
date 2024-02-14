﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PurposeCode5Choice.  ISO2002 ID# _AeehNtokEeC60axPepSq7g_1734090960.
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
    [KnownType(typeof(PurposeCode5Choice.Code))]
    [KnownType(typeof(PurposeCode5Choice.Proprietary))]
    [IsoId("_AeehNtokEeC60axPepSq7g_1734090960")]
    [DisplayName("Purpose Code 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PurposeCode5Choice_
    #else
    public abstract partial class PurposeCode5Choice_
    #endif
    {
    }
}
