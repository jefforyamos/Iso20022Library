﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InterestRateFrequency3Choice.  ISO2002 ID# _61uTH1fREeqqKf65rDYWYw.
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
    /// Describes frequency of payments for interest rates, either using term notation or a proprietary notation.
    /// </summary>
    [KnownType(typeof(InterestRateFrequency3Choice.Term))]
    [KnownType(typeof(InterestRateFrequency3Choice.Proprietary))]
    [IsoId("_61uTH1fREeqqKf65rDYWYw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Interest Rate Frequency 3 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRateFrequency3Choice_
    #else
    public abstract partial class InterestRateFrequency3Choice_
    #endif
    {
    }
}
